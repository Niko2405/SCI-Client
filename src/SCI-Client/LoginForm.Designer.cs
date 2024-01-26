namespace SCI_Client
{
	partial class LoginForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			panel1 = new Panel();
			labelTitle = new Label();
			textBoxPassword = new TextBox();
			textBoxUsername = new TextBox();
			textBoxServerAddress = new TextBox();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			buttonLogin = new Button();
			buttonExit = new Button();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.Controls.Add(labelTitle);
			panel1.Controls.Add(textBoxPassword);
			panel1.Controls.Add(textBoxUsername);
			panel1.Controls.Add(textBoxServerAddress);
			panel1.Controls.Add(label3);
			panel1.Controls.Add(label2);
			panel1.Controls.Add(label1);
			panel1.Controls.Add(buttonLogin);
			panel1.Controls.Add(buttonExit);
			panel1.Dock = DockStyle.Fill;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(1258, 664);
			panel1.TabIndex = 1;
			// 
			// labelTitle
			// 
			labelTitle.AutoSize = true;
			labelTitle.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
			labelTitle.Location = new Point(468, 9);
			labelTitle.Name = "labelTitle";
			labelTitle.Size = new Size(297, 70);
			labelTitle.TabIndex = 8;
			labelTitle.Text = "SCI - Client";
			// 
			// textBoxPassword
			// 
			textBoxPassword.Cursor = Cursors.IBeam;
			textBoxPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			textBoxPassword.Location = new Point(567, 379);
			textBoxPassword.Name = "textBoxPassword";
			textBoxPassword.PasswordChar = '*';
			textBoxPassword.Size = new Size(255, 39);
			textBoxPassword.TabIndex = 7;
			// 
			// textBoxUsername
			// 
			textBoxUsername.Cursor = Cursors.IBeam;
			textBoxUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			textBoxUsername.Location = new Point(567, 309);
			textBoxUsername.Name = "textBoxUsername";
			textBoxUsername.Size = new Size(255, 39);
			textBoxUsername.TabIndex = 6;
			// 
			// textBoxServerAddress
			// 
			textBoxServerAddress.Cursor = Cursors.IBeam;
			textBoxServerAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			textBoxServerAddress.Location = new Point(567, 240);
			textBoxServerAddress.Name = "textBoxServerAddress";
			textBoxServerAddress.Size = new Size(255, 39);
			textBoxServerAddress.TabIndex = 5;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label3.Location = new Point(386, 379);
			label3.Name = "label3";
			label3.Size = new Size(111, 32);
			label3.TabIndex = 4;
			label3.Text = "Password";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label2.Location = new Point(376, 309);
			label2.Name = "label2";
			label2.Size = new Size(121, 32);
			label2.TabIndex = 3;
			label2.Text = "Username";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label1.Location = new Point(325, 240);
			label1.Name = "label1";
			label1.Size = new Size(172, 32);
			label1.TabIndex = 2;
			label1.Text = "Server Address";
			// 
			// buttonLogin
			// 
			buttonLogin.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			buttonLogin.Location = new Point(1046, 607);
			buttonLogin.Name = "buttonLogin";
			buttonLogin.Size = new Size(200, 45);
			buttonLogin.TabIndex = 1;
			buttonLogin.Text = "Login";
			buttonLogin.UseVisualStyleBackColor = true;
			buttonLogin.Click += buttonLogin_Click;
			// 
			// buttonExit
			// 
			buttonExit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			buttonExit.Location = new Point(12, 607);
			buttonExit.Name = "buttonExit";
			buttonExit.Size = new Size(200, 45);
			buttonExit.TabIndex = 0;
			buttonExit.Text = "Exit";
			buttonExit.UseVisualStyleBackColor = true;
			buttonExit.Click += buttonExit_Click;
			// 
			// LoginForm
			// 
			AutoScaleDimensions = new SizeF(11F, 28F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1258, 664);
			Controls.Add(panel1);
			Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
			FormBorderStyle = FormBorderStyle.Fixed3D;
			MinimumSize = new Size(1200, 700);
			Name = "LoginForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Login";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion
		private Panel panel1;
		private Button buttonLogin;
		private Button buttonExit;
		private TextBox textBoxPassword;
		private TextBox textBoxUsername;
		private TextBox textBoxServerAddress;
		private Label label3;
		private Label label2;
		private Label label1;
		private Label labelTitle;
	}
}
