namespace myPass
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			navigationPanel = new Panel();
			firstPanel = new Panel();
			vaultBtn = new Button();
			generatorBtn = new Button();
			homeBtn = new Button();
			exitBtn = new PictureBox();
			logo = new PictureBox();
			welcomeLabel = new Label();
			mainText = new Label();
			panel2 = new Panel();
			generatePassword2 = new GeneratePassword();
			createPassword2 = new CreatePassword();
			getstartedBtn = new PictureBox();
			shieldPicture = new PictureBox();
			myVault1 = new MyVault();
			navigationPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)exitBtn).BeginInit();
			((System.ComponentModel.ISupportInitialize)logo).BeginInit();
			panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)getstartedBtn).BeginInit();
			((System.ComponentModel.ISupportInitialize)shieldPicture).BeginInit();
			SuspendLayout();
			// 
			// navigationPanel
			// 
			navigationPanel.BackColor = Color.FromArgb(24, 29, 22);
			navigationPanel.Controls.Add(firstPanel);
			navigationPanel.Controls.Add(vaultBtn);
			navigationPanel.Controls.Add(generatorBtn);
			navigationPanel.Controls.Add(homeBtn);
			navigationPanel.Controls.Add(exitBtn);
			navigationPanel.Controls.Add(logo);
			navigationPanel.Dock = DockStyle.Left;
			navigationPanel.Location = new Point(0, 0);
			navigationPanel.Margin = new Padding(4, 5, 4, 5);
			navigationPanel.Name = "navigationPanel";
			navigationPanel.Size = new Size(267, 651);
			navigationPanel.TabIndex = 0;
			// 
			// firstPanel
			// 
			firstPanel.BackColor = Color.FromArgb(138, 144, 102);
			firstPanel.Location = new Point(16, 171);
			firstPanel.Margin = new Padding(4, 5, 4, 5);
			firstPanel.Name = "firstPanel";
			firstPanel.Size = new Size(13, 59);
			firstPanel.TabIndex = 5;
			// 
			// vaultBtn
			// 
			vaultBtn.FlatAppearance.BorderSize = 0;
			vaultBtn.FlatStyle = FlatStyle.Flat;
			vaultBtn.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			vaultBtn.ForeColor = Color.White;
			vaultBtn.Location = new Point(21, 331);
			vaultBtn.Margin = new Padding(4, 5, 4, 5);
			vaultBtn.Name = "vaultBtn";
			vaultBtn.Size = new Size(223, 59);
			vaultBtn.TabIndex = 4;
			vaultBtn.Text = "Vault";
			vaultBtn.UseVisualStyleBackColor = true;
			vaultBtn.Click += vaultBtn_Click;
			// 
			// generatorBtn
			// 
			generatorBtn.FlatAppearance.BorderSize = 0;
			generatorBtn.FlatStyle = FlatStyle.Flat;
			generatorBtn.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			generatorBtn.ForeColor = Color.White;
			generatorBtn.Location = new Point(21, 248);
			generatorBtn.Margin = new Padding(4, 5, 4, 5);
			generatorBtn.Name = "generatorBtn";
			generatorBtn.Size = new Size(223, 59);
			generatorBtn.TabIndex = 3;
			generatorBtn.Text = "Generator";
			generatorBtn.UseVisualStyleBackColor = true;
			generatorBtn.Click += generatorBtn_Click;
			// 
			// homeBtn
			// 
			homeBtn.FlatAppearance.BorderSize = 0;
			homeBtn.FlatStyle = FlatStyle.Flat;
			homeBtn.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			homeBtn.ForeColor = Color.White;
			homeBtn.Location = new Point(21, 171);
			homeBtn.Margin = new Padding(4, 5, 4, 5);
			homeBtn.Name = "homeBtn";
			homeBtn.Size = new Size(223, 59);
			homeBtn.TabIndex = 2;
			homeBtn.Text = "Home";
			homeBtn.UseVisualStyleBackColor = true;
			homeBtn.Click += homeBtn_Click;
			// 
			// exitBtn
			// 
			exitBtn.Image = Properties.Resources.Exit;
			exitBtn.Location = new Point(76, 558);
			exitBtn.Margin = new Padding(4, 5, 4, 5);
			exitBtn.Name = "exitBtn";
			exitBtn.Size = new Size(105, 65);
			exitBtn.SizeMode = PictureBoxSizeMode.Zoom;
			exitBtn.TabIndex = 1;
			exitBtn.TabStop = false;
			exitBtn.Click += exitBtn_Click;
			exitBtn.MouseLeave += exitBtn_MouseLeave;
			exitBtn.MouseHover += exitBtn_MouseHover;
			// 
			// logo
			// 
			logo.Image = Properties.Resources.Logo;
			logo.Location = new Point(48, 49);
			logo.Margin = new Padding(4, 5, 4, 5);
			logo.Name = "logo";
			logo.Size = new Size(159, 51);
			logo.SizeMode = PictureBoxSizeMode.Zoom;
			logo.TabIndex = 0;
			logo.TabStop = false;
			// 
			// welcomeLabel
			// 
			welcomeLabel.AutoSize = true;
			welcomeLabel.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			welcomeLabel.ForeColor = Color.White;
			welcomeLabel.ImageAlign = ContentAlignment.TopLeft;
			welcomeLabel.Location = new Point(40, 49);
			welcomeLabel.Margin = new Padding(4, 0, 4, 0);
			welcomeLabel.Name = "welcomeLabel";
			welcomeLabel.Size = new Size(152, 21);
			welcomeLabel.TabIndex = 1;
			welcomeLabel.Text = "Welcome to myPass";
			welcomeLabel.TextAlign = ContentAlignment.BottomRight;
			// 
			// mainText
			// 
			mainText.AutoSize = true;
			mainText.Font = new Font("Calibri", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
			mainText.ForeColor = Color.White;
			mainText.Location = new Point(31, 125);
			mainText.Margin = new Padding(4, 0, 4, 0);
			mainText.Name = "mainText";
			mainText.Size = new Size(313, 146);
			mainText.TabIndex = 2;
			mainText.Text = "Secure \nYour Logins";
			// 
			// panel2
			// 
			panel2.BackColor = Color.FromArgb(138, 144, 102);
			panel2.Controls.Add(myVault1);
			panel2.Controls.Add(generatePassword2);
			panel2.Controls.Add(createPassword2);
			panel2.Controls.Add(getstartedBtn);
			panel2.Controls.Add(mainText);
			panel2.Controls.Add(welcomeLabel);
			panel2.Controls.Add(shieldPicture);
			panel2.Dock = DockStyle.Fill;
			panel2.Location = new Point(267, 0);
			panel2.Margin = new Padding(4, 5, 4, 5);
			panel2.Name = "panel2";
			panel2.Size = new Size(805, 651);
			panel2.TabIndex = 0;
			// 
			// generatePassword2
			// 
			generatePassword2.BackColor = Color.FromArgb(138, 144, 102);
			generatePassword2.Location = new Point(0, 0);
			generatePassword2.Margin = new Padding(4, 5, 4, 5);
			generatePassword2.Name = "generatePassword2";
			generatePassword2.Size = new Size(805, 651);
			generatePassword2.TabIndex = 5;
			// 
			// createPassword2
			// 
			createPassword2.BackColor = Color.FromArgb(138, 144, 102);
			createPassword2.Location = new Point(0, 0);
			createPassword2.Margin = new Padding(4, 5, 4, 5);
			createPassword2.Name = "createPassword2";
			createPassword2.Size = new Size(805, 651);
			createPassword2.TabIndex = 4;
			// 
			// getstartedBtn
			// 
			getstartedBtn.Image = Properties.Resources.Get_Started;
			getstartedBtn.Location = new Point(613, 558);
			getstartedBtn.Margin = new Padding(4, 5, 4, 5);
			getstartedBtn.Name = "getstartedBtn";
			getstartedBtn.Size = new Size(133, 89);
			getstartedBtn.SizeMode = PictureBoxSizeMode.Zoom;
			getstartedBtn.TabIndex = 3;
			getstartedBtn.TabStop = false;
			getstartedBtn.Click += getstartedBtn_Click;
			getstartedBtn.MouseLeave += getstartedBtn_MouseLeave;
			getstartedBtn.MouseHover += getstartedBtn_MouseHover;
			// 
			// shieldPicture
			// 
			shieldPicture.Image = Properties.Resources.Shield;
			shieldPicture.Location = new Point(317, 366);
			shieldPicture.Margin = new Padding(4, 5, 4, 5);
			shieldPicture.Name = "shieldPicture";
			shieldPicture.Size = new Size(165, 162);
			shieldPicture.SizeMode = PictureBoxSizeMode.Zoom;
			shieldPicture.TabIndex = 0;
			shieldPicture.TabStop = false;
			// 
			// myVault1
			// 
			myVault1.BackColor = Color.FromArgb(138, 144, 102);
			myVault1.Location = new Point(0, 0);
			myVault1.Margin = new Padding(4, 5, 4, 5);
			myVault1.Name = "myVault1";
			myVault1.Size = new Size(805, 651);
			myVault1.TabIndex = 1;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1072, 651);
			Controls.Add(panel2);
			Controls.Add(navigationPanel);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Icon = (Icon)resources.GetObject("$this.Icon");
			Margin = new Padding(4, 5, 4, 5);
			MaximizeBox = false;
			Name = "MainForm";
			Text = "myPass";
			Load += MainForm_Load;
			navigationPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)exitBtn).EndInit();
			((System.ComponentModel.ISupportInitialize)logo).EndInit();
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)getstartedBtn).EndInit();
			((System.ComponentModel.ISupportInitialize)shieldPicture).EndInit();
			ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel navigationPanel;
		private System.Windows.Forms.PictureBox logo;
		private System.Windows.Forms.PictureBox exitBtn;
		private System.Windows.Forms.Button vaultBtn;
		private System.Windows.Forms.Button generatorBtn;
		private System.Windows.Forms.Button homeBtn;
		private System.Windows.Forms.Panel firstPanel;
		private System.Windows.Forms.PictureBox shieldPicture;
		private System.Windows.Forms.Label welcomeLabel;
		private System.Windows.Forms.Label mainText;
		private System.Windows.Forms.PictureBox getstartedBtn;
		private System.Windows.Forms.Panel panel2;
		private MyVault myVault2;
		private GeneratePassword generatePassword2;
		private CreatePassword createPassword2;
		private MyVault myVault1;
	}
}