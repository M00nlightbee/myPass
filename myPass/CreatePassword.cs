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
	public partial class CreatePassword : UserControl
	{
		// Event to notify when a password is added
		public event EventHandler<PasswordData>? PasswordAdded;

		public CreatePassword()
		{
			InitializeComponent();
			if (DesignMode)
				return;
		}

		private void CreatePassword_Load(object sender, EventArgs e)
		{
			if (DesignMode)
				return;
		}

		internal PasswordData GetPasswordData()
		{
			string website = textBoxWebsite.Text;
			if (!string.IsNullOrEmpty(website))
				website = char.ToUpper(website[0]) + website.Substring(1);

			return new PasswordData(
				website,
				textBoxUsername.Text,
				textBoxPassword.Text
			);
		}

		// Copy Password Button
		private void copyPassword_Click(object sender, EventArgs e)
		{
			if (DesignMode) return;
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
			if (DesignMode) return;
			this.copyPassword.Image = Properties.Resources.Copy_Hover;
			this.Cursor = Cursors.Hand;
		}

		private void copyPassword_MouseLeave(object sender, EventArgs e)
		{
			if (DesignMode) return;
			this.copyPassword.Image = Properties.Resources.Copy;
			this.Cursor = Cursors.Default;
		}

		// Copy Username Button
		private void copyUsername_Click(object sender, EventArgs e)
		{
			if (DesignMode) return;
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
			if (DesignMode) return;
			this.copyUsername.Image = Properties.Resources.Copy_Hover;
			this.Cursor = Cursors.Hand;
		}
		private void copyUsername_MouseLeave(object sender, EventArgs e)
		{
			if (DesignMode) return;
			this.copyUsername.Image = Properties.Resources.Copy;
			this.Cursor = Cursors.Default;
		}

		// Add Button
		private void addBtn_Click(object sender, EventArgs e)
		{
			if (DesignMode) return;
			// Validate input
			if (string.IsNullOrWhiteSpace(textBoxWebsite.Text) ||
				string.IsNullOrWhiteSpace(textBoxUsername.Text) ||
				string.IsNullOrWhiteSpace(textBoxPassword.Text))
			{
				MessageBox.Show("All fields must be filled out.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			var passwordData = GetPasswordData();
			var passwordList = new List<PasswordData>();

			var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "passwordData.json");

			if (File.Exists(filePath))
			{
				try
				{
					var json = File.ReadAllText(filePath);
					var existingData = JsonSerializer.Deserialize<List<PasswordData>>(json);
					if (existingData != null)
					{
						passwordList.AddRange(existingData);
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show($"Error loading existing password details: {ex.Message}", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				// Prevent duplicate website
				if (passwordList.Any(p => p.GetWebpageName().Equals(passwordData.GetWebpageName(), StringComparison.OrdinalIgnoreCase)))
				{
					MessageBox.Show("An entry for this website already exists.", "Duplicate Website", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
			}

			// Add and save
			passwordList.Add(passwordData);
			SaveData(passwordList, filePath);

			// Raise the event to notify subscribers
			PasswordAdded?.Invoke(this, passwordData);

			// Clear fields
			textBoxWebsite.Clear();
			textBoxUsername.Clear();
			textBoxPassword.Clear();

		}

		private void addBtn_MouseHover(object sender, EventArgs e)
		{
			if (DesignMode) return;
			this.addBtn.Image = Properties.Resources.Add_Btn_Hover;
			this.Cursor = Cursors.Hand;
		}

		private void addBtn_MouseLeave(object sender, EventArgs e)
		{
			if (DesignMode) return;
			this.addBtn.Image = Properties.Resources.Add_Btn;
			this.Cursor = Cursors.Default;
		}

		// Make textBoxPassword accessible outside CrreatePassword user control
		public void SetGeneratedPassword(string password)
		{
			if (DesignMode) return;
			textBoxPassword.Text = password;
		}

		// Save data to JSON file
		internal void SaveData(List<PasswordData> data, string filePath)
		{
			if (DesignMode) return;
			try
			{
				var options = new JsonSerializerOptions { WriteIndented = true };
				var json = JsonSerializer.Serialize(data, options);
				File.WriteAllText(filePath, json);

				MessageBox.Show("Password Details saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error saving password details: " + ex.Message, "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
