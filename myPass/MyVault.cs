using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myPass
{
	public partial class MyVault : UserControl
	{
		private List<string> allWebsites = new List<string>();
		// Event to notify MainForm to switch to CreatePassword control
		public event EventHandler? RequestCreatePassword;

		public MyVault()
		{
			InitializeComponent();
			if (DesignMode)
				return;
		}

		private void MyVault_Load(object sender, EventArgs e)
		{
			if (DesignMode) return;

			if (loadAllPassword == null || filterListBox == null)
				return;

			loadAllPassword.DrawMode = DrawMode.OwnerDrawFixed;
			loadAllPassword.DrawItem += loadAllPasswords_DrawItem;
			filterListBox.TextChanged += filterListBox_TextChanged;
			DisableTextBoxes();
		}

		//private void MyVault_Load(object sender, EventArgs e)
		//{
		//	if (DesignMode) return;
		//	// Set custom draw mode for ListBox
		//	loadAllPassword.DrawMode = DrawMode.OwnerDrawFixed;
		//	loadAllPassword.DrawItem += loadAllPasswords_DrawItem;
		//	filterListBox.TextChanged += filterListBox_TextChanged;
		//	DisableTextBoxes();
		//}

		// Refresh the password list after adding a new password
		public void ReloadPasswords()
		{
			loadAllPassword.Items.Clear();
			LoadData();
		}

		private void LoadData()
		{
			if (DesignMode) return; // Avoid file I/O at design time

			allWebsites.Clear();
			var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "passwordData.json");

			if (File.Exists(filePath))
			{
				try
				{
					var json = File.ReadAllText(filePath);
					var data = JsonSerializer.Deserialize<List<PasswordData>>(json);

					// First check if the list itself is null
					if (data != null)
					{
						foreach (var d in data)
						{
							if (d != null && !string.IsNullOrEmpty(d.GetWebpageName()))
							{
								allWebsites.Add(d.GetWebpageName());
							}
						}
					}
					else
					{
						MessageBox.Show("No saved passwords found.");
						return;
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show($"Error reading or deserializing data: {ex.Message}");
				}
			}
			UpdateListBox();
		}

		// Custom draw for ListBox items 
		private void loadAllPasswords_DrawItem(object? sender, DrawItemEventArgs e)
		{
			if (e.Index < 0) return;
			// Get item text 
			string text = loadAllPassword.Items[e.Index]?.ToString() ?? string.Empty;
			// Determine colors 
			Color backColor = (e.State & DrawItemState.Selected) == DrawItemState.Selected ? Color.FromArgb(24, 29, 22) : loadAllPassword.BackColor;
			Color foreColor = (e.State & DrawItemState.Selected) == DrawItemState.Selected ? Color.White : loadAllPassword.ForeColor;
			// Draw background 
			using (SolidBrush backgroundBrush = new SolidBrush(backColor))
			{
				e.Graphics.FillRectangle(backgroundBrush, e.Bounds);
			}
			// Draw text 
			TextRenderer.DrawText(e.Graphics, text, e.Font, e.Bounds, foreColor, TextFormatFlags.Left | TextFormatFlags.VerticalCenter);
			// Draw focus rectangle
			e.DrawFocusRectangle();
		}

		private void loadAllPassword_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (loadAllPassword.SelectedItem != null)
			{
				var selectedWebsite = loadAllPassword.SelectedItem.ToString();
				var json = File.ReadAllText("passwordData.json");
				var data = JsonSerializer.Deserialize<List<PasswordData>>(json);
				var passwordData = data?.FirstOrDefault(d => d.GetWebpageName() == selectedWebsite?.ToString());

				if (passwordData != null)
				{
					textBoxWebsite.Text = passwordData.GetWebpageName();
					textBoxUsername.Text = passwordData.GetUserName();
					textBoxPassword.Text = passwordData.GetPassword();
				}
			}
		}

		// Delete Button to remove selected password entry
		private void deleteBtn_Click(object sender, EventArgs e)
		{
			if (loadAllPassword.SelectedItem == null)
			{
				MessageBox.Show("Please select a website to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			else
			{
				if (loadAllPassword.SelectedIndex != -1)
				{
					// Ask for confirmation before deletion
					DialogResult result = MessageBox.Show(
						"Are you sure you want to delete this password entry?",
						"Confirm Deletion",
						MessageBoxButtons.YesNo,
						MessageBoxIcon.Warning);

					if (result == DialogResult.Yes)
					{
						var selectedWebsite = loadAllPassword.SelectedItem.ToString();
						var json = File.ReadAllText("passwordData.json");
						var data = JsonSerializer.Deserialize<List<PasswordData>>(json);

						if (data != null)
						{
							var itemToRemove = data.FirstOrDefault(d => d.GetWebpageName() == selectedWebsite);
							if (itemToRemove != null)
							{
								data.Remove(itemToRemove);

								var options = new JsonSerializerOptions { WriteIndented = true };
								var updatedJson = JsonSerializer.Serialize(data, options);
								File.WriteAllText("passwordData.json", updatedJson);

								loadAllPassword.Items.RemoveAt(loadAllPassword.SelectedIndex);
								textBoxWebsite.Clear();
								textBoxUsername.Clear();
								textBoxPassword.Clear();

								MessageBox.Show("Password details deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
							}
						}
					}
					else
					{
						MessageBox.Show("Deletion cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
			}

		}

		private void deleteBtn_MouseHover(object sender, EventArgs e)
		{
			this.deleteBtn.ForeColor = Color.FromArgb(232, 44, 2);
			this.Cursor = Cursors.Hand;
		}

		private void deleteBtn_MouseLeave(object sender, EventArgs e)
		{
			this.deleteBtn.ForeColor = Color.White;
			this.Cursor = Cursors.Default;
		}

		// Edit Button to enable textboxes for editing
		private void editBtn_Click(object sender, EventArgs e)
		{
			if (loadAllPassword.SelectedItem == null)
			{
				MessageBox.Show("Please select a website to edit.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			EnabelTextBoxes();
		}

		private void editBtn_MouseHover(object sender, EventArgs e)
		{
			this.editBtn.Image = Properties.Resources.Edit_Hover;
			this.Cursor = Cursors.Hand;
		}

		private void editBtn_MouseLeave(object sender, EventArgs e)
		{
			this.editBtn.Image = Properties.Resources.Edit;
			this.Cursor = Cursors.Default;
		}

		private void updateBtn_Click(object sender, EventArgs e)
		{
			if (DesignMode) return;

			// Check if textboxes are in Edit mode (check that edit button has been clicked)
			if (!textBoxWebsite.Enabled || !textBoxUsername.Enabled || !textBoxPassword.Enabled)
			{
				MessageBox.Show(
					"Please click the Edit button before updating details.",
					"Edit Required",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning
				);
				return;
			}

			// 1. Validate that an item is selected in the ListBox
			if (loadAllPassword.SelectedItem == null)
			{
				MessageBox.Show("Please select website from list to update details.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			// 2. Validate that the input fields are not empty
			if (string.IsNullOrWhiteSpace(textBoxWebsite.Text) ||
				string.IsNullOrWhiteSpace(textBoxUsername.Text) ||
				string.IsNullOrWhiteSpace(textBoxPassword.Text))
			{
				MessageBox.Show("All Website details must be filled out to perform an update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			var selectedWebsite = loadAllPassword.SelectedItem.ToString();
			var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "passwordData.json");

			try
			{
				// 3. Read the JSON file content
				if (!File.Exists(filePath))
				{
					MessageBox.Show("Password data file not found.", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				var json = File.ReadAllText(filePath);

				// 4. Deserialize the JSON into a list of PasswordData objects
				var data = JsonSerializer.Deserialize<List<PasswordData>>(json);
				if (data == null)
				{
					MessageBox.Show("Error reading data from file.", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				// 5. Find the index of the item to be updated
				int indexToUpdate = data.FindIndex(d => d.GetWebpageName() == selectedWebsite);

				if (indexToUpdate != -1)
				{
					var existingItem = data[indexToUpdate];

					// 6. Detect if there are no changes
					if (existingItem.GetWebpageName().Equals(textBoxWebsite.Text, StringComparison.OrdinalIgnoreCase) &&
						existingItem.GetUserName().Equals(textBoxUsername.Text, StringComparison.OrdinalIgnoreCase) &&
						existingItem.GetPassword().Equals(textBoxPassword.Text))
					{
						MessageBox.Show("No changes made. Nothing to update.", "No Changes", MessageBoxButtons.OK, MessageBoxIcon.Information);
						DisableTextBoxes();
						return;
					}

					// 7. Create a new PasswordData object with the updated values
					var updatedItem = new PasswordData(textBoxWebsite.Text, textBoxUsername.Text, textBoxPassword.Text);

					// 8. Replace the old object with the new one in the list
					data[indexToUpdate] = updatedItem;

					// 9. Serialize the updated list back to JSON
					var options = new JsonSerializerOptions { WriteIndented = true };
					var updatedJson = JsonSerializer.Serialize(data, options);

					// 10. Write the updated JSON to the file, overwriting the old content
					File.WriteAllText(filePath, updatedJson);

					MessageBox.Show("Website details updated successfully.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

					// 11. Update the ListBox to reflect the change
					loadAllPassword.Items[indexToUpdate] = textBoxWebsite.Text;
				}
				else
				{
					MessageBox.Show("Selected Website not found in file.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error updating entry: {ex.Message}", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			DisableTextBoxes();
		}


		private void updateBtn_MouseHover(object sender, EventArgs e)
		{
			this.updateBtn.Image = Properties.Resources.Update_Hover;
			this.Cursor = Cursors.Hand;
		}

		private void updateBtn_MouseLeave(object sender, EventArgs e)
		{
			this.updateBtn.Image = Properties.Resources.Update;
			this.Cursor = Cursors.Default;
		}

		// Filter ListBox based on user input
		private void filterListBox_TextChanged(object? sender, EventArgs e)
		{
			UpdateListBox();
		}

		// Clear filter textbox and reset ListBox
		private void clearBtn_Click(object sender, EventArgs e)
		{
			filterListBox.Text = string.Empty; // Reset the filter textbox
			UpdateListBox();
		}

		private void clearBtn_MouseHover(object sender, EventArgs e)
		{
			this.clearBtn.ForeColor = Color.FromArgb(214, 252, 40);
			this.Cursor = Cursors.Hand;
		}

		private void clearBtn_MouseLeave(object sender, EventArgs e)
		{
			this.clearBtn.ForeColor = Color.White;
			this.Cursor = Cursors.Default;
		}

		private void UpdateListBox()
		{
			loadAllPassword.Items.Clear();
			string filter = filterListBox.Text.Trim().ToLower();
			foreach (var site in allWebsites)
			{
				if (string.IsNullOrEmpty(filter) || site.ToLower().Contains(filter))
				{
					loadAllPassword.Items.Add(site);
				}
			}
		}

		private void newPasswordBtn_Click(object sender, EventArgs e)
		{
			if (DesignMode) return;
			// Raise event to notify MainForm to switch to CreatePassword control
			RequestCreatePassword?.Invoke(this, EventArgs.Empty);
		}

		private void newPasswordBtn_MouseHover(object sender, EventArgs e)
		{
			this.newPasswordBtn.Image = Properties.Resources.New_Password_Hover;
			this.Cursor = Cursors.Hand;
		}

		private void newPasswordBtn_MouseLeave(object sender, EventArgs e)
		{
			this.newPasswordBtn.Image = Properties.Resources.New_Password;
			this.Cursor = Cursors.Default;
		}

		public void EnabelTextBoxes()
		{
			textBoxWebsite.Enabled = true;
			textBoxUsername.Enabled = true;
			textBoxPassword.Enabled = true;
		}

		public void DisableTextBoxes()
		{
			textBoxWebsite.Enabled = false;
			textBoxUsername.Enabled = false;
			textBoxPassword.Enabled = false;
		}

		// Copy Password Button
		private void copyPassword_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(textBoxPassword.Text))
			{
				Clipboard.SetText(textBoxPassword.Text);
				MessageBox.Show("Password copied to clipboard!");
			}
			else
			{
				MessageBox.Show("No password to copy.");
			}
		}
		private void copyPassword_MouseHover(object sender, EventArgs e)
		{
			this.copyPassword.Image = Properties.Resources.Copy_Hover;
			this.Cursor = Cursors.Hand;
		}

		private void copyPassword_MouseLeave(object sender, EventArgs e)
		{
			this.copyPassword.Image = Properties.Resources.Copy;
			this.Cursor = Cursors.Default;
		}

		// Copy Username Button
		private void copyUsername_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(textBoxUsername.Text))
			{
				Clipboard.SetText(textBoxUsername.Text);
				MessageBox.Show("Username/E-mail copied to clipboard!");
			}
			else
			{
				MessageBox.Show("No Username/E-mail to copy.");
			}
		}
		private void copyUsername_MouseHover(object sender, EventArgs e)
		{
			this.copyUsername.Image = Properties.Resources.Copy_Hover;
			this.Cursor = Cursors.Hand;
		}
		private void copyUsername_MouseLeave(object sender, EventArgs e)
		{
			this.copyUsername.Image = Properties.Resources.Copy;
			this.Cursor = Cursors.Default;
		}

	}
}