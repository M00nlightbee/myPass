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
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			// Future use:
			// Set custom cursor
			// https://www.c-sharpcorner.com/UploadFile/mahesh/cursors-in-C-Sharp/#:~:text=Current%20Cursor,.Position.Y%20%2D%20150);
			//this.Cursor = new Cursor(Application.StartupPath + "\\MyCursor.cur");
			// Subscribe to cross-control events
			if (!DesignMode)
			{
				if (createPassword2 != null)
					createPassword2.PasswordAdded += CreatePassword_PasswordAdded;

				if (myVault1 != null)
					myVault1.RequestCreatePassword += MyVault_RequestCreatePassword;

				if (generatePassword2 != null)
					generatePassword2.RequestCreatePassword += GeneratePassword_RequestCreatePassword;
			}

		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			position(homeBtn);
			Active(homeBtn);
			// Hide all at startup except the home screen
			myVault1.Hide();
			generatePassword2.Hide();
			createPassword2.Hide();
		}

		// ======== EVENT HANDLERS ========

		private void CreatePassword_PasswordAdded(object? sender, PasswordData passwordData)
		{
			// Switch back to the vault and refresh
			SetActiveUserControl(myVault1);
			myVault1.ReloadPasswords();
			position(vaultBtn);
			Active(vaultBtn);
		}

		// When "New Password" is clicked in MyVault
		private void MyVault_RequestCreatePassword(object? sender, EventArgs e)
		{
			// Switch to CreatePassword control
			SetActiveUserControl(createPassword2);

			position(vaultBtn);
			Active(vaultBtn);
		}


		// When "Save" is clicked in GeneratePassword
		private void GeneratePassword_RequestCreatePassword(object? sender, string generatedPassword)
		{
			// Copy generated password from GeneratePassword to CreatePassword
			createPassword2.SetGeneratedPassword(generatedPassword);

			// Switch to CreatePassword control
			SetActiveUserControl(createPassword2);

			position(generatorBtn);
			Active(generatorBtn);
		}

		private void homeBtn_Click(object sender, EventArgs e)
		{
			position(homeBtn);
			Active(homeBtn);
			SetActiveUserControl(null);
		}

		private void generatorBtn_Click(object sender, EventArgs e)
		{

			position(generatorBtn);
			Active(generatorBtn);
			SetActiveUserControl(generatePassword2);

		}

		private void vaultBtn_Click(object sender, EventArgs e)
		{
			position(vaultBtn);
			Active(vaultBtn);
			myVault1.ReloadPasswords();
			SetActiveUserControl(myVault1);
		}

		private void getstartedBtn_Click(object sender, EventArgs e)
		{
			position(generatorBtn);
			Active(generatorBtn);
			SetActiveUserControl(generatePassword2);
		}

		private void exitBtn_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		// Change with image when MouseHover and MouseLeave
		// Source:https://nareshkamuni.blogspot.com/2012/04/how-to-change-image-when-mousehover-and.html
		private void exitBtn_MouseHover(object sender, EventArgs e)
		{
			this.exitBtn.Image = Properties.Resources.Exit_Hover;
			this.Cursor = Cursors.Hand;
		}

		private void exitBtn_MouseLeave(object sender, EventArgs e)
		{
			this.exitBtn.Image = Properties.Resources.Exit;
			this.Cursor = Cursors.Default;
		}

		private void getstartedBtn_MouseHover(object sender, EventArgs e)
		{
			this.getstartedBtn.Image = Properties.Resources.Get_Started_Hover;
			this.Cursor = Cursors.Hand;
		}

		private void getstartedBtn_MouseLeave(object sender, EventArgs e)
		{
			this.getstartedBtn.Image = Properties.Resources.Get_Started;
			this.Cursor = Cursors.Default;
		}

		public void position(Button btn)
		{
			firstPanel.Location = new Point(btn.Location.X - firstPanel.Width, btn.Location.Y);
		}

		// Active button color change
		public void Active(Button btn)
		{
			foreach (Control ctr in navigationPanel.Controls)
			{
				if (ctr is Button button)
				{
					if (button.Name == btn.Name)
					{
						button.BackColor = Color.FromArgb(104, 119, 95);
						button.ForeColor = Color.White;
					}
					else
					{
						button.BackColor = Color.FromArgb(24, 29, 22);
						button.ForeColor = Color.White;
					}
				}
			}
		}

		public void SetActiveUserControl(UserControl? activeControl)
		{
			// Hide all UserControl first
			generatePassword2.Visible = false;
			createPassword2.Visible = false;
			myVault1.Visible = false;

			if (activeControl != null)
			{
				activeControl.Visible = true;
				activeControl.BringToFront(); 
			}
		}


	}
}
