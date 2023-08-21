namespace MiniMartInventory.Forms
{
	partial class FrmSeller
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
			this.dGrid = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.TxtPassword = new System.Windows.Forms.TextBox();
			this.TxtAge = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.TxtPhone = new System.Windows.Forms.TextBox();
			this.LblSellerID = new System.Windows.Forms.Label();
			this.BtnUpdate = new System.Windows.Forms.Button();
			this.BtnDelete = new System.Windows.Forms.Button();
			this.BtnAdd = new System.Windows.Forms.Button();
			this.TxtName = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dGrid)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dGrid
			// 
			this.dGrid.AllowUserToAddRows = false;
			this.dGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dGrid.Location = new System.Drawing.Point(0, 285);
			this.dGrid.Name = "dGrid";
			this.dGrid.RowHeadersVisible = false;
			this.dGrid.RowHeadersWidth = 51;
			this.dGrid.RowTemplate.Height = 24;
			this.dGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dGrid.Size = new System.Drawing.Size(961, 225);
			this.dGrid.TabIndex = 7;
			this.dGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGrid_CellContentClick);
			this.dGrid.Click += new System.EventHandler(this.dGrid_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.groupBox1.Controls.Add(this.TxtPassword);
			this.groupBox1.Controls.Add(this.TxtAge);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.TxtPhone);
			this.groupBox1.Controls.Add(this.LblSellerID);
			this.groupBox1.Controls.Add(this.BtnUpdate);
			this.groupBox1.Controls.Add(this.BtnDelete);
			this.groupBox1.Controls.Add(this.BtnAdd);
			this.groupBox1.Controls.Add(this.TxtName);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(1, 69);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(960, 211);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Manage Cashier";
			// 
			// TxtPassword
			// 
			this.TxtPassword.Location = new System.Drawing.Point(651, 99);
			this.TxtPassword.Name = "TxtPassword";
			this.TxtPassword.Size = new System.Drawing.Size(280, 28);
			this.TxtPassword.TabIndex = 4;
			// 
			// TxtAge
			// 
			this.TxtAge.Location = new System.Drawing.Point(651, 52);
			this.TxtAge.Name = "TxtAge";
			this.TxtAge.Size = new System.Drawing.Size(280, 28);
			this.TxtAge.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(516, 99);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(89, 22);
			this.label3.TabIndex = 16;
			this.label3.Text = "Password";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(516, 52);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(127, 22);
			this.label5.TabIndex = 15;
			this.label5.Text = "Cashier\'s Age:";
			// 
			// TxtPhone
			// 
			this.TxtPhone.Location = new System.Drawing.Point(155, 99);
			this.TxtPhone.Name = "TxtPhone";
			this.TxtPhone.Size = new System.Drawing.Size(280, 28);
			this.TxtPhone.TabIndex = 2;
			// 
			// LblSellerID
			// 
			this.LblSellerID.AutoSize = true;
			this.LblSellerID.Location = new System.Drawing.Point(208, 24);
			this.LblSellerID.Name = "LblSellerID";
			this.LblSellerID.Size = new System.Drawing.Size(24, 22);
			this.LblSellerID.TabIndex = 13;
			this.LblSellerID.Text = "Id";
			// 
			// BtnUpdate
			// 
			this.BtnUpdate.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.BtnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.BtnUpdate.Location = new System.Drawing.Point(410, 160);
			this.BtnUpdate.Name = "BtnUpdate";
			this.BtnUpdate.Size = new System.Drawing.Size(103, 35);
			this.BtnUpdate.TabIndex = 11;
			this.BtnUpdate.Text = "Update";
			this.BtnUpdate.UseVisualStyleBackColor = false;
			this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
			// 
			// BtnDelete
			// 
			this.BtnDelete.BackColor = System.Drawing.Color.Red;
			this.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.BtnDelete.Location = new System.Drawing.Point(519, 160);
			this.BtnDelete.Name = "BtnDelete";
			this.BtnDelete.Size = new System.Drawing.Size(101, 35);
			this.BtnDelete.TabIndex = 10;
			this.BtnDelete.Text = "Delete";
			this.BtnDelete.UseVisualStyleBackColor = false;
			this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
			// 
			// BtnAdd
			// 
			this.BtnAdd.BackColor = System.Drawing.SystemColors.Highlight;
			this.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.BtnAdd.Location = new System.Drawing.Point(317, 160);
			this.BtnAdd.Name = "BtnAdd";
			this.BtnAdd.Size = new System.Drawing.Size(87, 35);
			this.BtnAdd.TabIndex = 9;
			this.BtnAdd.Text = "Add";
			this.BtnAdd.UseVisualStyleBackColor = false;
			this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
			// 
			// TxtName
			// 
			this.TxtName.Location = new System.Drawing.Point(155, 52);
			this.TxtName.Name = "TxtName";
			this.TxtName.Size = new System.Drawing.Size(280, 28);
			this.TxtName.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(5, 99);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(95, 22);
			this.label4.TabIndex = 6;
			this.label4.Text = "Phone No.";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(5, 52);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(142, 22);
			this.label2.TabIndex = 4;
			this.label2.Text = "Cashier\'s Name:";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(961, 64);
			this.panel1.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(308, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(382, 32);
			this.label1.TabIndex = 2;
			this.label1.Text = "Mini-Mart Inventory System";
			// 
			// FrmSeller
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(961, 512);
			this.Controls.Add(this.dGrid);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.panel1);
			this.Name = "FrmSeller";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Manage Seller";
			this.Load += new System.EventHandler(this.FrmSeller_Load);
			((System.ComponentModel.ISupportInitialize)(this.dGrid)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dGrid;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label LblSellerID;
		private System.Windows.Forms.Button BtnUpdate;
		private System.Windows.Forms.Button BtnDelete;
		private System.Windows.Forms.Button BtnAdd;
		private System.Windows.Forms.TextBox TxtName;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox TxtPassword;
		private System.Windows.Forms.TextBox TxtAge;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox TxtPhone;
	}
}