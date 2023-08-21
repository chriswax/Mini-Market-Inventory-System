namespace MiniMartInventory
{
	partial class FrmLogin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.TxtUsername = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.BtnClear = new System.Windows.Forms.Button();
			this.BtnLogin = new System.Windows.Forms.Button();
			this.CmbRole = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.TxtPassword = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(583, 64);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(122, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(382, 32);
			this.label1.TabIndex = 2;
			this.label1.Text = "Mini-Mart Inventory System";
			// 
			// TxtUsername
			// 
			this.TxtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtUsername.Location = new System.Drawing.Point(136, 43);
			this.TxtUsername.Name = "TxtUsername";
			this.TxtUsername.Size = new System.Drawing.Size(195, 30);
			this.TxtUsername.TabIndex = 1;
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.groupBox1.Controls.Add(this.BtnClear);
			this.groupBox1.Controls.Add(this.BtnLogin);
			this.groupBox1.Controls.Add(this.CmbRole);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.TxtPassword);
			this.groupBox1.Controls.Add(this.TxtUsername);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(230, 69);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(357, 240);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Authentication";
			// 
			// BtnClear
			// 
			this.BtnClear.BackColor = System.Drawing.Color.Red;
			this.BtnClear.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.BtnClear.Location = new System.Drawing.Point(247, 180);
			this.BtnClear.Name = "BtnClear";
			this.BtnClear.Size = new System.Drawing.Size(84, 35);
			this.BtnClear.TabIndex = 8;
			this.BtnClear.Text = "Clear";
			this.BtnClear.UseVisualStyleBackColor = false;
			this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
			// 
			// BtnLogin
			// 
			this.BtnLogin.BackColor = System.Drawing.SystemColors.Highlight;
			this.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.BtnLogin.Location = new System.Drawing.Point(136, 180);
			this.BtnLogin.Name = "BtnLogin";
			this.BtnLogin.Size = new System.Drawing.Size(87, 35);
			this.BtnLogin.TabIndex = 7;
			this.BtnLogin.Text = "Login";
			this.BtnLogin.UseVisualStyleBackColor = false;
			this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
			// 
			// CmbRole
			// 
			this.CmbRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CmbRole.FormattingEnabled = true;
			this.CmbRole.Items.AddRange(new object[] {
            "--Select Role--",
            "Admin",
            "Sales",
            "Accountant"});
			this.CmbRole.Location = new System.Drawing.Point(136, 130);
			this.CmbRole.Name = "CmbRole";
			this.CmbRole.Size = new System.Drawing.Size(195, 33);
			this.CmbRole.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(14, 91);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(98, 25);
			this.label4.TabIndex = 5;
			this.label4.Text = "Password";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(14, 141);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(97, 25);
			this.label3.TabIndex = 4;
			this.label3.Text = "User Role";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(14, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(102, 25);
			this.label2.TabIndex = 3;
			this.label2.Text = "Username";
			// 
			// TxtPassword
			// 
			this.TxtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtPassword.Location = new System.Drawing.Point(136, 86);
			this.TxtPassword.Name = "TxtPassword";
			this.TxtPassword.PasswordChar = '*';
			this.TxtPassword.Size = new System.Drawing.Size(195, 30);
			this.TxtPassword.TabIndex = 2;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(3, 67);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(227, 226);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 9;
			this.pictureBox1.TabStop = false;
			// 
			// FrmLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(583, 295);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.Load += new System.EventHandler(this.FrmLogin_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox TxtUsername;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox CmbRole;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox TxtPassword;
		private System.Windows.Forms.Button BtnLogin;
		private System.Windows.Forms.Button BtnClear;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}

