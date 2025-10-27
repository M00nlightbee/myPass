namespace myPass
{
	partial class CreatePassword
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
			pictureBox1 = new PictureBox();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			textBoxWebsite = new TextBox();
			textBoxUsername = new TextBox();
			textBoxPassword = new TextBox();
			copyUsername = new PictureBox();
			copyPassword = new PictureBox();
			addBtn = new PictureBox();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)copyUsername).BeginInit();
			((System.ComponentModel.ISupportInitialize)copyPassword).BeginInit();
			((System.ComponentModel.ISupportInitialize)addBtn).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Calibri", 36F, FontStyle.Bold);
			label1.ForeColor = Color.White;
			label1.Location = new Point(104, 32);
			label1.Margin = new Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new Size(574, 73);
			label1.TabIndex = 0;
			label1.Text = "Create New Password";
			// 
			// pictureBox1
			// 
			pictureBox1.Image = myPass.Properties.Resources.Create_New_Password;
			pictureBox1.Location = new Point(57, 157);
			pictureBox1.Margin = new Padding(4, 5, 4, 5);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(696, 483);
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 1;
			pictureBox1.TabStop = false;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.BackColor = Color.FromArgb(24, 29, 22);
			label2.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.ForeColor = Color.White;
			label2.Location = new Point(241, 234);
			label2.Margin = new Padding(4, 0, 4, 0);
			label2.Name = "label2";
			label2.Size = new Size(68, 21);
			label2.TabIndex = 2;
			label2.Text = "Website";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.BackColor = Color.FromArgb(24, 29, 22);
			label3.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label3.ForeColor = Color.White;
			label3.Location = new Point(241, 354);
			label3.Margin = new Padding(4, 0, 4, 0);
			label3.Name = "label3";
			label3.Size = new Size(133, 21);
			label3.TabIndex = 3;
			label3.Text = "Username/E-mail";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.BackColor = Color.FromArgb(24, 29, 22);
			label4.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label4.ForeColor = Color.White;
			label4.Location = new Point(241, 460);
			label4.Margin = new Padding(4, 0, 4, 0);
			label4.Name = "label4";
			label4.Size = new Size(78, 21);
			label4.TabIndex = 4;
			label4.Text = "Password";
			// 
			// textBoxWebsite
			// 
			textBoxWebsite.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			textBoxWebsite.ForeColor = Color.FromArgb(0, 115, 80);
			textBoxWebsite.Location = new Point(245, 265);
			textBoxWebsite.Margin = new Padding(4, 5, 4, 5);
			textBoxWebsite.Name = "textBoxWebsite";
			textBoxWebsite.Size = new Size(349, 30);
			textBoxWebsite.TabIndex = 5;
			textBoxWebsite.TextAlign = HorizontalAlignment.Center;
			// 
			// textBoxUsername
			// 
			textBoxUsername.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			textBoxUsername.ForeColor = Color.FromArgb(0, 115, 80);
			textBoxUsername.Location = new Point(245, 385);
			textBoxUsername.Margin = new Padding(4, 5, 4, 5);
			textBoxUsername.Name = "textBoxUsername";
			textBoxUsername.Size = new Size(349, 30);
			textBoxUsername.TabIndex = 6;
			textBoxUsername.TextAlign = HorizontalAlignment.Center;
			// 
			// textBoxPassword
			// 
			textBoxPassword.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			textBoxPassword.ForeColor = Color.FromArgb(0, 115, 80);
			textBoxPassword.Location = new Point(245, 491);
			textBoxPassword.Margin = new Padding(4, 5, 4, 5);
			textBoxPassword.Name = "textBoxPassword";
			textBoxPassword.Size = new Size(349, 30);
			textBoxPassword.TabIndex = 7;
			textBoxPassword.TextAlign = HorizontalAlignment.Center;
			// 
			// copyUsername
			// 
			copyUsername.BackColor = Color.FromArgb(24, 29, 22);
			copyUsername.Image = myPass.Properties.Resources.Copy;
			copyUsername.Location = new Point(607, 385);
			copyUsername.Margin = new Padding(4, 5, 4, 5);
			copyUsername.Name = "copyUsername";
			copyUsername.Size = new Size(22, 22);
			copyUsername.SizeMode = PictureBoxSizeMode.AutoSize;
			copyUsername.TabIndex = 8;
			copyUsername.TabStop = false;
			copyUsername.Click += copyUsername_Click;
			copyUsername.MouseLeave += copyUsername_MouseLeave;
			copyUsername.MouseHover += copyUsername_MouseHover;
			// 
			// copyPassword
			// 
			copyPassword.BackColor = Color.FromArgb(24, 29, 22);
			copyPassword.Image = myPass.Properties.Resources.Copy;
			copyPassword.Location = new Point(607, 491);
			copyPassword.Margin = new Padding(4, 5, 4, 5);
			copyPassword.Name = "copyPassword";
			copyPassword.Size = new Size(22, 22);
			copyPassword.SizeMode = PictureBoxSizeMode.AutoSize;
			copyPassword.TabIndex = 9;
			copyPassword.TabStop = false;
			copyPassword.Click += copyPassword_Click;
			copyPassword.MouseLeave += copyPassword_MouseLeave;
			copyPassword.MouseHover += copyPassword_MouseHover;
			// 
			// addBtn
			// 
			addBtn.BackColor = Color.FromArgb(24, 29, 22);
			addBtn.Image = myPass.Properties.Resources.Add_Btn;
			addBtn.Location = new Point(344, 548);
			addBtn.Margin = new Padding(4, 5, 4, 5);
			addBtn.Name = "addBtn";
			addBtn.Size = new Size(135, 41);
			addBtn.SizeMode = PictureBoxSizeMode.AutoSize;
			addBtn.TabIndex = 10;
			addBtn.TabStop = false;
			addBtn.Click += addBtn_Click;
			addBtn.MouseLeave += addBtn_MouseLeave;
			addBtn.MouseHover += addBtn_MouseHover;
			// 
			// CreatePassword
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(138, 144, 102);
			Controls.Add(addBtn);
			Controls.Add(copyPassword);
			Controls.Add(copyUsername);
			Controls.Add(textBoxPassword);
			Controls.Add(textBoxUsername);
			Controls.Add(textBoxWebsite);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(pictureBox1);
			Controls.Add(label1);
			Location = new Point(43, 102);
			Margin = new Padding(4, 5, 4, 5);
			Name = "CreatePassword";
			Size = new Size(805, 651);
			Load += CreatePassword_Load;
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)copyUsername).EndInit();
			((System.ComponentModel.ISupportInitialize)copyPassword).EndInit();
			((System.ComponentModel.ISupportInitialize)addBtn).EndInit();
			ResumeLayout(false);
			PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxWebsite;
		private System.Windows.Forms.TextBox textBoxUsername;
		private System.Windows.Forms.TextBox textBoxPassword;
		private System.Windows.Forms.PictureBox copyUsername;
		private System.Windows.Forms.PictureBox copyPassword;
		private System.Windows.Forms.PictureBox addBtn;
	}
}
