namespace MiniMartInventory.Forms
{
	partial class FrmCategory
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.LblCatID = new System.Windows.Forms.Label();
			this.RchTxtCatDesc = new System.Windows.Forms.RichTextBox();
			this.BtnCategoryUpdate = new System.Windows.Forms.Button();
			this.BtnCategoryDelete = new System.Windows.Forms.Button();
			this.BtnCategoryAdd = new System.Windows.Forms.Button();
			this.TxtCatName = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dGrdCategory = new System.Windows.Forms.DataGridView();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dGrdCategory)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1114, 64);
			this.panel1.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(370, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(382, 32);
			this.label1.TabIndex = 2;
			this.label1.Text = "Mini-Mart Inventory System";
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.groupBox1.Controls.Add(this.LblCatID);
			this.groupBox1.Controls.Add(this.RchTxtCatDesc);
			this.groupBox1.Controls.Add(this.BtnCategoryUpdate);
			this.groupBox1.Controls.Add(this.BtnCategoryDelete);
			this.groupBox1.Controls.Add(this.BtnCategoryAdd);
			this.groupBox1.Controls.Add(this.TxtCatName);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(0, 67);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(509, 306);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Add Category";
			// 
			// LblCatID
			// 
			this.LblCatID.AutoSize = true;
			this.LblCatID.Location = new System.Drawing.Point(209, 24);
			this.LblCatID.Name = "LblCatID";
			this.LblCatID.Size = new System.Drawing.Size(0, 22);
			this.LblCatID.TabIndex = 13;
			// 
			// RchTxtCatDesc
			// 
			this.RchTxtCatDesc.Location = new System.Drawing.Point(191, 99);
			this.RchTxtCatDesc.Name = "RchTxtCatDesc";
			this.RchTxtCatDesc.Size = new System.Drawing.Size(280, 136);
			this.RchTxtCatDesc.TabIndex = 2;
			this.RchTxtCatDesc.Text = "";
			// 
			// BtnCategoryUpdate
			// 
			this.BtnCategoryUpdate.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.BtnCategoryUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnCategoryUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.BtnCategoryUpdate.Location = new System.Drawing.Point(274, 250);
			this.BtnCategoryUpdate.Name = "BtnCategoryUpdate";
			this.BtnCategoryUpdate.Size = new System.Drawing.Size(103, 35);
			this.BtnCategoryUpdate.TabIndex = 11;
			this.BtnCategoryUpdate.Text = "Update";
			this.BtnCategoryUpdate.UseVisualStyleBackColor = false;
			this.BtnCategoryUpdate.Click += new System.EventHandler(this.BtnCategoryUpdate_Click);
			// 
			// BtnCategoryDelete
			// 
			this.BtnCategoryDelete.BackColor = System.Drawing.Color.Red;
			this.BtnCategoryDelete.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnCategoryDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.BtnCategoryDelete.Location = new System.Drawing.Point(383, 250);
			this.BtnCategoryDelete.Name = "BtnCategoryDelete";
			this.BtnCategoryDelete.Size = new System.Drawing.Size(101, 35);
			this.BtnCategoryDelete.TabIndex = 10;
			this.BtnCategoryDelete.Text = "Delete";
			this.BtnCategoryDelete.UseVisualStyleBackColor = false;
			this.BtnCategoryDelete.Click += new System.EventHandler(this.BtnCategoryDelete_Click);
			// 
			// BtnCategoryAdd
			// 
			this.BtnCategoryAdd.BackColor = System.Drawing.SystemColors.Highlight;
			this.BtnCategoryAdd.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnCategoryAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.BtnCategoryAdd.Location = new System.Drawing.Point(181, 250);
			this.BtnCategoryAdd.Name = "BtnCategoryAdd";
			this.BtnCategoryAdd.Size = new System.Drawing.Size(87, 35);
			this.BtnCategoryAdd.TabIndex = 9;
			this.BtnCategoryAdd.Text = "Add";
			this.BtnCategoryAdd.UseVisualStyleBackColor = false;
			this.BtnCategoryAdd.Click += new System.EventHandler(this.BtnCategoryAdd_Click);
			// 
			// TxtCatName
			// 
			this.TxtCatName.Location = new System.Drawing.Point(191, 52);
			this.TxtCatName.Name = "TxtCatName";
			this.TxtCatName.Size = new System.Drawing.Size(280, 28);
			this.TxtCatName.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(5, 99);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(183, 22);
			this.label4.TabIndex = 6;
			this.label4.Text = "Category Description:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(5, 52);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(140, 22);
			this.label2.TabIndex = 4;
			this.label2.Text = "Category Name:";
			// 
			// dGrdCategory
			// 
			this.dGrdCategory.AllowUserToAddRows = false;
			this.dGrdCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dGrdCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dGrdCategory.Location = new System.Drawing.Point(505, 67);
			this.dGrdCategory.Name = "dGrdCategory";
			this.dGrdCategory.RowHeadersVisible = false;
			this.dGrdCategory.RowHeadersWidth = 51;
			this.dGrdCategory.RowTemplate.Height = 24;
			this.dGrdCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dGrdCategory.Size = new System.Drawing.Size(609, 306);
			this.dGrdCategory.TabIndex = 4;
			this.dGrdCategory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGrdCategory_CellContentClick);
			this.dGrdCategory.Click += new System.EventHandler(this.dGrdCategory_Click);
			// 
			// FrmCategory
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1114, 364);
			this.Controls.Add(this.dGrdCategory);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.panel1);
			this.Name = "FrmCategory";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Category";
			this.Load += new System.EventHandler(this.FrmCategory_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dGrdCategory)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox TxtCatName;
		private System.Windows.Forms.Button BtnCategoryDelete;
		private System.Windows.Forms.Button BtnCategoryAdd;
		private System.Windows.Forms.Button BtnCategoryUpdate;
		private System.Windows.Forms.RichTextBox RchTxtCatDesc;
		private System.Windows.Forms.DataGridView dGrdCategory;
		private System.Windows.Forms.Label LblCatID;
	}
}