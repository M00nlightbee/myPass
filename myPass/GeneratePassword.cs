using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myPass
{
	public partial class GeneratePassword : UserControl
	{
		Image? toggleOn;
		Image? toggleOff;
		public event EventHandler<string>? RequestCreatePassword;
		private CreatePassword? createPasswordControl;

		public GeneratePassword()
		{
			InitializeComponent();
			if (!DesignMode)
			{
				createPasswordControl = new CreatePassword();
			}
		}

		private void GeneratePassword_Load(object sender, EventArgs e)
		{
			if (DesignMode) return; // Skip logic at design-time

			textBoxLowerCase.Hide();
			textBoxUpperCase.Hide();
			textBoxSymbols.Hide();
			textBoxNumbers.Hide();
			passwordLength.Hide();

			toggleOn = Properties.Resources.SwitchOn;
			toggleOff = Properties.Resources.SwitchOff;

			textBoxGenerated.Enabled = false;
		}


		private void lowerCaseSwitch_MouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				if (lowerCaseSwitch.Image != toggleOn)
				{
					lowerCaseSwitch.Image = toggleOn;
					textBoxLowerCase.Show();
				}
				else
				{
					lowerCaseSwitch.Image = toggleOff;
					textBoxLowerCase.Clear();
					textBoxLowerCase.Hide();
				}
			}
		}

		private void upperCaseSwitch_MouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				if (upperCaseSwitch.Image != toggleOn)
				{
					upperCaseSwitch.Image = toggleOn;
					textBoxUpperCase.Show();
				}
				else
				{
					upperCaseSwitch.Image = toggleOff;
					textBoxUpperCase.Clear();
					textBoxUpperCase.Hide();
				}
			}
		}

		private void symbolSwitch_MouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				if (symbolSwitch.Image != toggleOn)
				{
					symbolSwitch.Image = toggleOn;
					textBoxSymbols.Show();
				}
				else
				{
					symbolSwitch.Image = toggleOff;
					textBoxSymbols.Clear();
					textBoxSymbols.Hide();
				}
			}
		}

		private void numberSwitch_MouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				if (numberSwitch.Image != toggleOn)
				{
					numberSwitch.Image = toggleOn;
					textBoxNumbers.Show();
				}
				else
				{
					numberSwitch.Image = toggleOff;
					textBoxNumbers.Clear();
					textBoxNumbers.Hide();
				}
			}
		}

		// Generate password button
		private void generateBtn_Click(object sender, EventArgs e)
		{
			Character c = new Character();
			Random r = new Random();

			// Count how many switches are ON
			int activeSwitches = 0;
			if (lowerCaseSwitch.Image == toggleOn) activeSwitches++;
			if (upperCaseSwitch.Image == toggleOn) activeSwitches++;
			if (symbolSwitch.Image == toggleOn) activeSwitches++;
			if (numberSwitch.Image == toggleOn) activeSwitches++;

			// Ensure at least two switches are ON
			if (activeSwitches < 2)
			{
				MessageBox.Show("Please enable at least TWO character types to generate a password.");
				return;
			}

			// Validate inputs only for active switches
			int llCase = 0, ulCase = 0, scCase = 0, numCase = 0;

			// Populate random value in text box when toggle is on and allow for custom user input
			if (lowerCaseSwitch.Image == toggleOn)
			{
				if (string.IsNullOrWhiteSpace(textBoxLowerCase.Text))
				{
					textBoxLowerCase.Text = r.Next(4, Math.Min(5, c.lowerCase.Length)).ToString();
				}
				if (!int.TryParse(textBoxLowerCase.Text, out llCase) || llCase <= 2 || llCase > c.lowerCase.Length)
				{
					MessageBox.Show($"Number of LOWER CASES is INVALID.\nENTER a valid integer between 2 and {c.lowerCase.Length}");
					return;
				}
			}

			if (upperCaseSwitch.Image == toggleOn)
			{
				if (string.IsNullOrWhiteSpace(textBoxUpperCase.Text))
				{
					textBoxUpperCase.Text = r.Next(4, Math.Min(5, c.upperCase.Length) + 1).ToString();
				}
				if (!int.TryParse(textBoxUpperCase.Text, out ulCase) || ulCase <= 2 || ulCase > c.upperCase.Length)
				{
					MessageBox.Show($"Number of UPPER CASES is INVALID.\nENTER a valid integer between 2 and {c.upperCase.Length}");
					return;
				}
			}

			if (symbolSwitch.Image == toggleOn)
			{
				if (string.IsNullOrWhiteSpace(textBoxSymbols.Text))
				{
					textBoxSymbols.Text = r.Next(4, Math.Min(5, c.symbol.Length) + 1).ToString();
				}
				if (!int.TryParse(textBoxSymbols.Text, out scCase) || scCase <= 2 || scCase > c.symbol.Length)
				{
					MessageBox.Show($"Number of SPECIAL CHARACTERS is INVALID.\nENTER a valid integer between 2 and {c.symbol.Length}");
					return;
				}
			}

			if (numberSwitch.Image == toggleOn)
			{
				if (string.IsNullOrWhiteSpace(textBoxNumbers.Text))
				{
					textBoxNumbers.Text = r.Next(4, Math.Min(5, c.number.Length) + 1).ToString();
				}
				if (!int.TryParse(textBoxNumbers.Text, out numCase) || numCase <= 2 || numCase > c.number.Length)
				{
					MessageBox.Show($"Number of NUMBERS is INVALID.\nENTER a valid integer between 2 and {c.number.Length}");
					return;
				}
			}

			// Build ordered password
			string oPassword = "";
			for (int i = 0; i < llCase && i < c.lowerCase.Length; i++) oPassword += c.lowerCase[i];
			for (int i = 0; i < ulCase && i < c.upperCase.Length; i++) oPassword += c.upperCase[i];
			for (int i = 0; i < scCase && i < c.symbol.Length; i++) oPassword += c.symbol[i];
			for (int i = 0; i < numCase && i < c.number.Length; i++) oPassword += c.number[i];

			if (oPassword.Length > 20)
			{
				MessageBox.Show("Password too long. Max length is 20.");
				return;
			}

			// Randomize password
			string randPassword = new string(oPassword.OrderBy(_ => r.Next()).ToArray());

			textBoxGenerated.Text = randPassword;
			textBoxGenerated.Enabled = false;

			passwordLength.Text = randPassword.Length.ToString();
			passwordLength.Show();
			passwordLength.Enabled = false;
		}


		private void generateBtn_MouseHover(object sender, EventArgs e)
		{
			this.generateBtn.Image = Properties.Resources.Generate_Btn_Hover;
			this.Cursor = Cursors.Hand;
		}

		private void generateBtn_MouseLeave(object sender, EventArgs e)
		{
			this.generateBtn.Image = Properties.Resources.Generate_Btn;
			this.Cursor = Cursors.Default;
		}

		// Copy Button
		private void copyBtn_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(textBoxGenerated.Text))
			{
				Clipboard.SetText(textBoxGenerated.Text);
				MessageBox.Show("Password copied to clipboard!");
			}
			else
			{
				MessageBox.Show("No password to copy.");
			}
		}

		private void copyBtn_MouseHover(object sender, EventArgs e)
		{
			this.copyBtn.Image = Properties.Resources.Copy_Hover;
			this.Cursor = Cursors.Hand;
		}

		private void copyBtn_MouseLeave(object sender, EventArgs e)
		{
			this.copyBtn.Image = Properties.Resources.Copy;
			this.Cursor = Cursors.Default;
		}

		private void saveBtn_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(textBoxGenerated.Text))
			{
				MessageBox.Show("No password to save. Please generate a password first.");
				return;
			}

			RequestCreatePassword?.Invoke(this, textBoxGenerated.Text);
		}

		private void saveBtn_MouseHover(object sender, EventArgs e)
		{
			this.saveBtn.Image = Properties.Resources.Save_Btn_Hover;
			this.Cursor = Cursors.Hand;
		}

		private void saveBtn_MouseLeave(object sender, EventArgs e)
		{
			this.saveBtn.Image = Properties.Resources.Save_Btn;
			this.Cursor = Cursors.Default;
		}

		// Access generated password oustside of generate password control
		//public string GetGeneratedPassword
		//{
		//	textBoxGenerated.Text;
		//}
	}
}
