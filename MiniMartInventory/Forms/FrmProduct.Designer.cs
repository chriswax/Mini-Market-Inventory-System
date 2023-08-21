namespace MiniMartInventory.Forms
{
	partial class FrmProduct
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
			this.TxtQty = new System.Windows.Forms.TextBox();
			this.TxtPrice = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.LblProductID = new System.Windows.Forms.Label();
			this.BtnUpdate = new System.Windows.Forms.Button();
			this.BtnDelete = new System.Windows.Forms.Button();
			this.BtnAdd = new System.Windows.Forms.Button();
			this.TxtName = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.CmbCat = new System.Windows.Forms.ComboBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.CmbSearch = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.BtnRefresh = new System.Windows.Forms.Button();
			this.BtnSearch = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dGrid)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// dGrid
			// 
			this.dGrid.AllowUserToAddRows = false;
			this.dGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dGrid.Location = new System.Drawing.Point(0, 307);
			this.dGrid.Name = "dGrid";
			this.dGrid.RowHeadersVisible = false;
			this.dGrid.RowHeadersWidth = 51;
			this.dGrid.RowTemplate.Height = 24;
			this.dGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dGrid.Size = new System.Drawing.Size(1236, 289);
			this.dGrid.TabIndex = 10;
			this.dGrid.Click += new System.EventHandler(this.dGrid_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.groupBox1.Controls.Add(this.panel2);
			this.groupBox1.Controls.Add(this.CmbCat);
			this.groupBox1.Controls.Add(this.TxtQty);
			this.groupBox1.Controls.Add(this.TxtPrice);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.LblProductID);
			this.groupBox1.Controls.Add(this.BtnUpdate);
			this.groupBox1.Controls.Add(this.BtnDelete);
			this.groupBox1.Controls.Add(this.BtnAdd);
			this.groupBox1.Controls.Add(this.TxtName);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(1, 68);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1235, 241);
			this.groupBox1.TabIndex = 9;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Manage Products";
			// 
			// TxtQty
			// 
			this.TxtQty.Location = new System.Drawing.Point(1005, 72);
			this.TxtQty.Name = "TxtQty";
			this.TxtQty.Size = new System.Drawing.Size(209, 28);
			this.TxtQty.TabIndex = 4;
			// 
			// TxtPrice
			// 
			this.TxtPrice.Location = new System.Drawing.Point(741, 72);
			this.TxtPrice.Name = "TxtPrice";
			this.TxtPrice.Size = new System.Drawing.Size(207, 28);
			this.TxtPrice.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(1001, 47);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(77, 22);
			this.label3.TabIndex = 16;
			this.label3.Text = "Quantity";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(737, 47);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(56, 22);
			this.label5.TabIndex = 15;
			this.label5.Text = "Price:";
			// 
			// LblProductID
			// 
			this.LblProductID.AutoSize = true;
			this.LblProductID.Location = new System.Drawing.Point(310, 19);
			this.LblProductID.Name = "LblProductID";
			this.LblProductID.Size = new System.Drawing.Size(24, 22);
			this.LblProductID.TabIndex = 13;
			this.LblProductID.Text = "Id";
			// 
			// BtnUpdate
			// 
			this.BtnUpdate.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.BtnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.BtnUpdate.Location = new System.Drawing.Point(520, 118);
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
			this.BtnDelete.Location = new System.Drawing.Point(629, 118);
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
			this.BtnAdd.Location = new System.Drawing.Point(427, 118);
			this.BtnAdd.Name = "BtnAdd";
			this.BtnAdd.Size = new System.Drawing.Size(87, 35);
			this.BtnAdd.TabIndex = 9;
			this.BtnAdd.Text = "Add";
			this.BtnAdd.UseVisualStyleBackColor = false;
			this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
			// 
			// TxtName
			// 
			this.TxtName.Location = new System.Drawing.Point(15, 72);
			this.TxtName.Name = "TxtName";
			this.TxtName.Size = new System.Drawing.Size(353, 28);
			this.TxtName.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(405, 47);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(88, 22);
			this.label4.TabIndex = 6;
			this.label4.Text = "Category:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(11, 47);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(129, 22);
			this.label2.TabIndex = 4;
			this.label2.Text = "Product Name:";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1236, 64);
			this.panel1.TabIndex = 8;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(391, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(382, 32);
			this.label1.TabIndex = 2;
			this.label1.Text = "Mini-Mart Inventory System";
			// 
			// CmbCat
			// 
			this.CmbCat.FormattingEnabled = true;
			this.CmbCat.Location = new System.Drawing.Point(409, 72);
			this.CmbCat.Name = "CmbCat";
			this.CmbCat.Size = new System.Drawing.Size(277, 30);
			this.CmbCat.TabIndex = 17;
			this.CmbCat.SelectedIndexChanged += new System.EventHandler(this.CmbCat_SelectedIndexChanged);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.BtnSearch);
			this.panel2.Controls.Add(this.BtnRefresh);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.CmbSearch);
			this.panel2.Location = new System.Drawing.Point(0, 183);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1235, 58);
			this.panel2.TabIndex = 11;
			// 
			// CmbSearch
			// 
			this.CmbSearch.FormattingEnabled = true;
			this.CmbSearch.Location = new System.Drawing.Point(166, 11);
			this.CmbSearch.Name = "CmbSearch";
			this.CmbSearch.Size = new System.Drawing.Size(616, 30);
			this.CmbSearch.TabIndex = 18;
			this.CmbSearch.SelectedIndexChanged += new System.EventHandler(this.CmbSearch_SelectedIndexChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(11, 14);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(139, 22);
			this.label6.TabIndex = 19;
			this.label6.Text = "Search Product:";
			// 
			// BtnRefresh
			// 
			this.BtnRefresh.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.BtnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnRefresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.BtnRefresh.Location = new System.Drawing.Point(1105, 11);
			this.BtnRefresh.Name = "BtnRefresh";
			this.BtnRefresh.Size = new System.Drawing.Size(118, 35);
			this.BtnRefresh.TabIndex = 20;
			this.BtnRefresh.Text = "Refresh";
			this.BtnRefresh.UseVisualStyleBackColor = false;
			this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
			// 
			// BtnSearch
			// 
			this.BtnSearch.BackColor = System.Drawing.Color.SeaGreen;
			this.BtnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.BtnSearch.Location = new System.Drawing.Point(799, 8);
			this.BtnSearch.Name = "BtnSearch";
			this.BtnSearch.Size = new System.Drawing.Size(120, 35);
			this.BtnSearch.TabIndex = 21;
			this.BtnSearch.Text = "Search";
			this.BtnSearch.UseVisualStyleBackColor = false;
			this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
			// 
			// FrmProduct
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1236, 595);
			this.Controls.Add(this.dGrid);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "FrmProduct";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Mini - Mart Inventory :: Product";
			this.Load += new System.EventHandler(this.FrmProduct_Load);
			((System.ComponentModel.ISupportInitialize)(this.dGrid)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dGrid;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox TxtQty;
		private System.Windows.Forms.TextBox TxtPrice;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label LblProductID;
		private System.Windows.Forms.Button BtnUpdate;
		private System.Windows.Forms.Button BtnDelete;
		private System.Windows.Forms.Button BtnAdd;
		private System.Windows.Forms.TextBox TxtName;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox CmbCat;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button BtnRefresh;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox CmbSearch;
		private System.Windows.Forms.Button BtnSearch;
	}
}