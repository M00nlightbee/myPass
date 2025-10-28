namespace myPass
{
	partial class MyVault
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			label1 = new Label();
			label2 = new Label();
			filterListBox = new TextBox();
			clearBtn = new Button();
			deleteBtn = new Button();
			label3 = new Label();
			loadAllPassword = new ListBox();
			label4 = new Label();
			label5 = new Label();
			label6 = new Label();
			textBoxWebsite = new TextBox();
			textBoxUsername = new TextBox();
			textBoxPassword = new TextBox();
			updateBtn = new PictureBox();
			copyPassword = new PictureBox();
			copyUsername = new PictureBox();
			editBtn = new PictureBox();
			pictureBox2 = new PictureBox();
			newPasswordBtn = new PictureBox();
			((System.ComponentModel.ISupportInitialize)updateBtn).BeginInit();
			((System.ComponentModel.ISupportInitialize)copyPassword).BeginInit();
			((System.ComponentModel.ISupportInitialize)copyUsername).BeginInit();
			((System.ComponentModel.ISupportInitialize)editBtn).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)newPasswordBtn).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Calibri", 36F, FontStyle.Bold);
			label1.ForeColor = Color.White;
			label1.Location = new Point(35, 22);
			label1.Margin = new Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new Size(256, 73);
			label1.TabIndex = 0;
			label1.Text = "My Vault";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.ForeColor = Color.FromArgb(24, 29, 22);
			label2.Location = new Point(44, 106);
			label2.Margin = new Padding(4, 0, 4, 0);
			label2.Name = "label2";
			label2.Size = new Size(53, 23);
			label2.TabIndex = 1;
			label2.Text = "Filter";
			// 
			// filterListBox
			// 
			filterListBox.Font = new Font("Calibri", 10.2F);
			filterListBox.Location = new Point(47, 135);
			filterListBox.Margin = new Padding(4, 5, 4, 5);
			filterListBox.Name = "filterListBox";
			filterListBox.Size = new Size(211, 28);
			filterListBox.TabIndex = 2;
			filterListBox.TextAlign = HorizontalAlignment.Center;
			// 
			// clearBtn
			// 
			clearBtn.BackColor = Color.FromArgb(24, 29, 22);
			clearBtn.FlatAppearance.BorderSize = 0;
			clearBtn.FlatStyle = FlatStyle.Flat;
			clearBtn.Font = new Font("Calibri", 7.8F, FontStyle.Bold);
			clearBtn.ForeColor = Color.White;
			clearBtn.Location = new Point(260, 135);
			clearBtn.Margin = new Padding(4, 5, 4, 5);
			clearBtn.Name = "clearBtn";
			clearBtn.Size = new Size(96, 28);
			clearBtn.TabIndex = 3;
			clearBtn.Text = "CLEAR";
			clearBtn.UseVisualStyleBackColor = false;
			clearBtn.Click += clearBtn_Click;
			clearBtn.MouseLeave += clearBtn_MouseLeave;
			clearBtn.MouseHover += clearBtn_MouseHover;
			// 
			// deleteBtn
			// 
			deleteBtn.BackColor = Color.Black;
			deleteBtn.FlatAppearance.BorderSize = 0;
			deleteBtn.FlatStyle = FlatStyle.Flat;
			deleteBtn.Font = new Font("Calibri", 9F, FontStyle.Bold);
			deleteBtn.ForeColor = Color.White;
			deleteBtn.Location = new Point(143, 586);
			deleteBtn.Margin = new Padding(4, 5, 4, 5);
			deleteBtn.Name = "deleteBtn";
			deleteBtn.Size = new Size(124, 52);
			deleteBtn.TabIndex = 4;
			deleteBtn.Text = "DELETE";
			deleteBtn.UseVisualStyleBackColor = false;
			deleteBtn.Click += deleteBtn_Click;
			deleteBtn.MouseLeave += deleteBtn_MouseLeave;
			deleteBtn.MouseHover += deleteBtn_MouseHover;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Calibri", 11.25F, FontStyle.Bold);
			label3.ForeColor = Color.FromArgb(24, 29, 22);
			label3.Location = new Point(44, 181);
			label3.Margin = new Padding(4, 0, 4, 0);
			label3.Name = "label3";
			label3.Size = new Size(112, 23);
			label3.TabIndex = 5;
			label3.Text = "Website List ";
			// 
			// loadAllPassword
			// 
			loadAllPassword.Font = new Font("Calibri", 12F);
			loadAllPassword.ForeColor = Color.FromArgb(24, 29, 22);
			loadAllPassword.FormattingEnabled = true;
			loadAllPassword.ItemHeight = 24;
			loadAllPassword.Location = new Point(47, 212);
			loadAllPassword.Margin = new Padding(4, 5, 4, 5);
			loadAllPassword.Name = "loadAllPassword";
			loadAllPassword.Size = new Size(308, 364);
			loadAllPassword.TabIndex = 6;
			loadAllPassword.SelectedIndexChanged += loadAllPassword_SelectedIndexChanged;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.BackColor = Color.FromArgb(24, 29, 22);
			label4.Font = new Font("Calibri", 11.25F, FontStyle.Bold);
			label4.ForeColor = Color.White;
			label4.Location = new Point(389, 217);
			label4.Margin = new Padding(4, 0, 4, 0);
			label4.Name = "label4";
			label4.Size = new Size(76, 23);
			label4.TabIndex = 13;
			label4.Text = "Website";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.BackColor = Color.FromArgb(24, 29, 22);
			label5.Font = new Font("Calibri", 11.25F, FontStyle.Bold);
			label5.ForeColor = Color.White;
			label5.Location = new Point(391, 325);
			label5.Margin = new Padding(4, 0, 4, 0);
			label5.Name = "label5";
			label5.Size = new Size(148, 23);
			label5.TabIndex = 14;
			label5.Text = "Username/E-mail";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.BackColor = Color.FromArgb(24, 29, 22);
			label6.Font = new Font("Calibri", 11.25F, FontStyle.Bold);
			label6.ForeColor = Color.White;
			label6.Location = new Point(389, 431);
			label6.Margin = new Padding(4, 0, 4, 0);
			label6.Name = "label6";
			label6.Size = new Size(86, 23);
			label6.TabIndex = 15;
			label6.Text = "Password";
			// 
			// textBoxWebsite
			// 
			textBoxWebsite.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			textBoxWebsite.ForeColor = Color.FromArgb(0, 115, 80);
			textBoxWebsite.Location = new Point(395, 244);
			textBoxWebsite.Margin = new Padding(4, 5, 4, 5);
			textBoxWebsite.Name = "textBoxWebsite";
			textBoxWebsite.Size = new Size(324, 30);
			textBoxWebsite.TabIndex = 16;
			textBoxWebsite.TextAlign = HorizontalAlignment.Center;
			// 
			// textBoxUsername
			// 
			textBoxUsername.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			textBoxUsername.ForeColor = Color.FromArgb(0, 115, 80);
			textBoxUsername.Location = new Point(395, 351);
			textBoxUsername.Margin = new Padding(4, 5, 4, 5);
			textBoxUsername.Name = "textBoxUsername";
			textBoxUsername.Size = new Size(324, 30);
			textBoxUsername.TabIndex = 17;
			textBoxUsername.TextAlign = HorizontalAlignment.Center;
			// 
			// textBoxPassword
			// 
			textBoxPassword.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			textBoxPassword.ForeColor = Color.FromArgb(0, 115, 80);
			textBoxPassword.Location = new Point(395, 457);
			textBoxPassword.Margin = new Padding(4, 5, 4, 5);
			textBoxPassword.Name = "textBoxPassword";
			textBoxPassword.Size = new Size(324, 30);
			textBoxPassword.TabIndex = 18;
			textBoxPassword.TextAlign = HorizontalAlignment.Center;
			// 
			// updateBtn
			// 
			updateBtn.BackColor = Color.FromArgb(24, 29, 22);
			updateBtn.Image = Properties.Resources.Update;
			updateBtn.Location = new Point(544, 542);
			updateBtn.Margin = new Padding(4, 5, 4, 5);
			updateBtn.Name = "updateBtn";
			updateBtn.Size = new Size(122, 29);
			updateBtn.SizeMode = PictureBoxSizeMode.AutoSize;
			updateBtn.TabIndex = 12;
			updateBtn.TabStop = false;
			updateBtn.Click += updateBtn_Click;
			updateBtn.MouseLeave += updateBtn_MouseLeave;
			updateBtn.MouseHover += updateBtn_MouseHover;
			// 
			// copyPassword
			// 
			copyPassword.BackColor = Color.FromArgb(24, 29, 22);
			copyPassword.Image = Properties.Resources.Copy;
			copyPassword.Location = new Point(728, 457);
			copyPassword.Margin = new Padding(4, 5, 4, 5);
			copyPassword.Name = "copyPassword";
			copyPassword.Size = new Size(22, 22);
			copyPassword.SizeMode = PictureBoxSizeMode.AutoSize;
			copyPassword.TabIndex = 11;
			copyPassword.TabStop = false;
			copyPassword.Click += copyPassword_Click;
			copyPassword.MouseLeave += copyPassword_MouseLeave;
			copyPassword.MouseHover += copyPassword_MouseHover;
			// 
			// copyUsername
			// 
			copyUsername.BackColor = Color.FromArgb(24, 29, 22);
			copyUsername.Image = Properties.Resources.Copy;
			copyUsername.Location = new Point(728, 351);
			copyUsername.Margin = new Padding(4, 5, 4, 5);
			copyUsername.Name = "copyUsername";
			copyUsername.Size = new Size(22, 22);
			copyUsername.SizeMode = PictureBoxSizeMode.AutoSize;
			copyUsername.TabIndex = 10;
			copyUsername.TabStop = false;
			copyUsername.Click += copyUsername_Click;
			copyUsername.MouseLeave += copyUsername_MouseLeave;
			copyUsername.MouseHover += copyUsername_MouseHover;
			// 
			// editBtn
			// 
			editBtn.BackColor = Color.FromArgb(24, 29, 22);
			editBtn.Image = Properties.Resources.Edit;
			editBtn.Location = new Point(412, 542);
			editBtn.Margin = new Padding(4, 5, 4, 5);
			editBtn.Name = "editBtn";
			editBtn.Size = new Size(67, 29);
			editBtn.SizeMode = PictureBoxSizeMode.AutoSize;
			editBtn.TabIndex = 9;
			editBtn.TabStop = false;
			editBtn.Click += editBtn_Click;
			editBtn.MouseLeave += editBtn_MouseLeave;
			editBtn.MouseHover += editBtn_MouseHover;
			// 
			// pictureBox2
			// 
			pictureBox2.Image = Properties.Resources.My_Vault;
			pictureBox2.Location = new Point(376, 181);
			pictureBox2.Margin = new Padding(4, 5, 4, 5);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(403, 443);
			pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox2.TabIndex = 8;
			pictureBox2.TabStop = false;
			// 
			// newPasswordBtn
			// 
			newPasswordBtn.Image = Properties.Resources.New_Password;
			newPasswordBtn.Location = new Point(584, 54);
			newPasswordBtn.Margin = new Padding(4, 5, 4, 5);
			newPasswordBtn.Name = "newPasswordBtn";
			newPasswordBtn.Size = new Size(135, 41);
			newPasswordBtn.SizeMode = PictureBoxSizeMode.AutoSize;
			newPasswordBtn.TabIndex = 7;
			newPasswordBtn.TabStop = false;
			newPasswordBtn.Click += newPasswordBtn_Click;
			newPasswordBtn.MouseLeave += newPasswordBtn_MouseLeave;
			newPasswordBtn.MouseHover += newPasswordBtn_MouseHover;
			// 
			// MyVault
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(138, 144, 102);
			Controls.Add(textBoxPassword);
			Controls.Add(textBoxUsername);
			Controls.Add(textBoxWebsite);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(updateBtn);
			Controls.Add(copyPassword);
			Controls.Add(copyUsername);
			Controls.Add(editBtn);
			Controls.Add(pictureBox2);
			Controls.Add(newPasswordBtn);
			Controls.Add(loadAllPassword);
			Controls.Add(label3);
			Controls.Add(deleteBtn);
			Controls.Add(clearBtn);
			Controls.Add(filterListBox);
			Controls.Add(label2);
			Controls.Add(label1);
			Location = new Point(481, 61);
			Margin = new Padding(4, 5, 4, 5);
			Name = "MyVault";
			Size = new Size(805, 651);
			Load += MyVault_Load;
			((System.ComponentModel.ISupportInitialize)updateBtn).EndInit();
			((System.ComponentModel.ISupportInitialize)copyPassword).EndInit();
			((System.ComponentModel.ISupportInitialize)copyUsername).EndInit();
			((System.ComponentModel.ISupportInitialize)editBtn).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)newPasswordBtn).EndInit();
			ResumeLayout(false);
			PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox filterListBox;
		private System.Windows.Forms.Button clearBtn;
		private System.Windows.Forms.Button deleteBtn;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ListBox loadAllPassword;
		private System.Windows.Forms.PictureBox newPasswordBtn;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox editBtn;
		private System.Windows.Forms.PictureBox copyUsername;
		private System.Windows.Forms.PictureBox copyPassword;
		private System.Windows.Forms.PictureBox updateBtn;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBoxWebsite;
		private System.Windows.Forms.TextBox textBoxUsername;
		private System.Windows.Forms.TextBox textBoxPassword;
	}
}