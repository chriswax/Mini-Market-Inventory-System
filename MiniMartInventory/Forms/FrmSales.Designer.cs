namespace MiniMartInventory.Forms
{
	partial class FrmSales
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
			this.LblDate = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.TxtID = new System.Windows.Forms.TextBox();
			this.TxtQty = new System.Windows.Forms.TextBox();
			this.TxtPrice = new System.Windows.Forms.TextBox();
			this.TxtProduct = new System.Windows.Forms.TextBox();
			this.BtnAddOrder = new System.Windows.Forms.Button();
			this.dGridSales = new System.Windows.Forms.DataGridView();
			this.label8 = new System.Windows.Forms.Label();
			this.LblAmount = new System.Windows.Forms.Label();
			this.BtnSearch = new System.Windows.Forms.Button();
			this.BtnRefresh = new System.Windows.Forms.Button();
			this.CmbCategory = new System.Windows.Forms.ComboBox();
			this.dGridSalesList = new System.Windows.Forms.DataGridView();
			this.button1 = new System.Windows.Forms.Button();
			this.BtnAddSales = new System.Windows.Forms.Button();
			this.dGridSearch = new System.Windows.Forms.DataGridView();
			this.label10 = new System.Windows.Forms.Label();
			this.ProID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TxtBillNo = new System.Windows.Forms.TextBox();
			this.BtnAddBill = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dGridSales)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dGridSalesList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dGridSearch)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
			this.panel1.Controls.Add(this.LblDate);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(1, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1390, 64);
			this.panel1.TabIndex = 2;
			// 
			// LblDate
			// 
			this.LblDate.AutoSize = true;
			this.LblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblDate.ForeColor = System.Drawing.Color.White;
			this.LblDate.Location = new System.Drawing.Point(1215, 25);
			this.LblDate.Name = "LblDate";
			this.LblDate.Size = new System.Drawing.Size(96, 25);
			this.LblDate.TabIndex = 4;
			this.LblDate.Text = "Dec 2023";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.RosyBrown;
			this.label2.Location = new System.Drawing.Point(1149, 25);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 25);
			this.label2.TabIndex = 3;
			this.label2.Text = "Date: ";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(609, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(218, 32);
			this.label1.TabIndex = 2;
			this.label1.Text = "Sales Manager";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(12, 94);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(37, 25);
			this.label4.TabIndex = 4;
			this.label4.Text = "ID:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(12, 231);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(96, 25);
			this.label5.TabIndex = 5;
			this.label5.Text = "Quantity: ";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Black;
			this.label6.Location = new System.Drawing.Point(12, 186);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(67, 25);
			this.label6.TabIndex = 6;
			this.label6.Text = "Price: ";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Black;
			this.label7.Location = new System.Drawing.Point(12, 139);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(90, 25);
			this.label7.TabIndex = 7;
			this.label7.Text = "Product: ";
			// 
			// TxtID
			// 
			this.TxtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtID.Location = new System.Drawing.Point(119, 89);
			this.TxtID.Name = "TxtID";
			this.TxtID.ReadOnly = true;
			this.TxtID.Size = new System.Drawing.Size(280, 30);
			this.TxtID.TabIndex = 10;
			// 
			// TxtQty
			// 
			this.TxtQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtQty.Location = new System.Drawing.Point(119, 231);
			this.TxtQty.Name = "TxtQty";
			this.TxtQty.Size = new System.Drawing.Size(280, 30);
			this.TxtQty.TabIndex = 11;
			// 
			// TxtPrice
			// 
			this.TxtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtPrice.Location = new System.Drawing.Point(119, 186);
			this.TxtPrice.Name = "TxtPrice";
			this.TxtPrice.ReadOnly = true;
			this.TxtPrice.Size = new System.Drawing.Size(280, 30);
			this.TxtPrice.TabIndex = 12;
			// 
			// TxtProduct
			// 
			this.TxtProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtProduct.Location = new System.Drawing.Point(119, 139);
			this.TxtProduct.Name = "TxtProduct";
			this.TxtProduct.ReadOnly = true;
			this.TxtProduct.Size = new System.Drawing.Size(280, 30);
			this.TxtProduct.TabIndex = 13;
			// 
			// BtnAddOrder
			// 
			this.BtnAddOrder.BackColor = System.Drawing.SystemColors.Highlight;
			this.BtnAddOrder.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnAddOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnAddOrder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.BtnAddOrder.Location = new System.Drawing.Point(119, 279);
			this.BtnAddOrder.Name = "BtnAddOrder";
			this.BtnAddOrder.Size = new System.Drawing.Size(143, 46);
			this.BtnAddOrder.TabIndex = 14;
			this.BtnAddOrder.Text = "Add Order";
			this.BtnAddOrder.UseVisualStyleBackColor = false;
			this.BtnAddOrder.Click += new System.EventHandler(this.BtnAddOrder_Click);
			// 
			// dGridSales
			// 
			this.dGridSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dGridSales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dGridSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dGridSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProID,
            this.ProductName,
            this.Price,
            this.Quantity,
            this.Total});
			this.dGridSales.Location = new System.Drawing.Point(431, 68);
			this.dGridSales.Name = "dGridSales";
			this.dGridSales.RowHeadersVisible = false;
			this.dGridSales.RowHeadersWidth = 51;
			this.dGridSales.RowTemplate.Height = 24;
			this.dGridSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dGridSales.Size = new System.Drawing.Size(948, 248);
			this.dGridSales.TabIndex = 15;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.Black;
			this.label8.Location = new System.Drawing.Point(1159, 319);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(93, 25);
			this.label8.TabIndex = 16;
			this.label8.Text = "Amount:";
			// 
			// LblAmount
			// 
			this.LblAmount.AutoSize = true;
			this.LblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblAmount.ForeColor = System.Drawing.Color.RoyalBlue;
			this.LblAmount.Location = new System.Drawing.Point(1258, 319);
			this.LblAmount.Name = "LblAmount";
			this.LblAmount.Size = new System.Drawing.Size(42, 25);
			this.LblAmount.TabIndex = 17;
			this.LblAmount.Text = "0.0";
			// 
			// BtnSearch
			// 
			this.BtnSearch.BackColor = System.Drawing.Color.SeaGreen;
			this.BtnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.BtnSearch.Location = new System.Drawing.Point(227, 339);
			this.BtnSearch.Name = "BtnSearch";
			this.BtnSearch.Size = new System.Drawing.Size(96, 40);
			this.BtnSearch.TabIndex = 24;
			this.BtnSearch.Text = "Search";
			this.BtnSearch.UseVisualStyleBackColor = false;
			this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
			// 
			// BtnRefresh
			// 
			this.BtnRefresh.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.BtnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnRefresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.BtnRefresh.Location = new System.Drawing.Point(336, 339);
			this.BtnRefresh.Name = "BtnRefresh";
			this.BtnRefresh.Size = new System.Drawing.Size(99, 40);
			this.BtnRefresh.TabIndex = 23;
			this.BtnRefresh.Text = "Refresh";
			this.BtnRefresh.UseVisualStyleBackColor = false;
			// 
			// CmbCategory
			// 
			this.CmbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CmbCategory.FormattingEnabled = true;
			this.CmbCategory.Location = new System.Drawing.Point(12, 343);
			this.CmbCategory.Name = "CmbCategory";
			this.CmbCategory.Size = new System.Drawing.Size(209, 33);
			this.CmbCategory.TabIndex = 22;
			// 
			// dGridSalesList
			// 
			this.dGridSalesList.AllowUserToAddRows = false;
			this.dGridSalesList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dGridSalesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dGridSalesList.Location = new System.Drawing.Point(589, 413);
			this.dGridSalesList.Name = "dGridSalesList";
			this.dGridSalesList.RowHeadersVisible = false;
			this.dGridSalesList.RowHeadersWidth = 51;
			this.dGridSalesList.RowTemplate.Height = 24;
			this.dGridSalesList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dGridSalesList.Size = new System.Drawing.Size(790, 225);
			this.dGridSalesList.TabIndex = 25;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button1.Location = new System.Drawing.Point(1181, 644);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(99, 40);
			this.button1.TabIndex = 26;
			this.button1.Text = "Refresh";
			this.button1.UseVisualStyleBackColor = false;
			// 
			// BtnAddSales
			// 
			this.BtnAddSales.BackColor = System.Drawing.Color.SeaGreen;
			this.BtnAddSales.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnAddSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnAddSales.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.BtnAddSales.Location = new System.Drawing.Point(1036, 644);
			this.BtnAddSales.Name = "BtnAddSales";
			this.BtnAddSales.Size = new System.Drawing.Size(96, 40);
			this.BtnAddSales.TabIndex = 27;
			this.BtnAddSales.Text = "Add";
			this.BtnAddSales.UseVisualStyleBackColor = false;
			// 
			// dGridSearch
			// 
			this.dGridSearch.AllowUserToAddRows = false;
			this.dGridSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dGridSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dGridSearch.Location = new System.Drawing.Point(12, 389);
			this.dGridSearch.Name = "dGridSearch";
			this.dGridSearch.RowHeadersVisible = false;
			this.dGridSearch.RowHeadersWidth = 51;
			this.dGridSearch.RowTemplate.Height = 24;
			this.dGridSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dGridSearch.Size = new System.Drawing.Size(528, 271);
			this.dGridSearch.TabIndex = 28;
			this.dGridSearch.Click += new System.EventHandler(this.dGridSearch_Click);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.BackColor = System.Drawing.SystemColors.Control;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.IndianRed;
			this.label10.Location = new System.Drawing.Point(584, 377);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(127, 29);
			this.label10.TabIndex = 29;
			this.label10.Text = "Sales List";
			// 
			// ProID
			// 
			this.ProID.HeaderText = "ProID";
			this.ProID.MinimumWidth = 6;
			this.ProID.Name = "ProID";
			// 
			// ProductName
			// 
			this.ProductName.HeaderText = "ProductName";
			this.ProductName.MinimumWidth = 6;
			this.ProductName.Name = "ProductName";
			// 
			// Price
			// 
			this.Price.HeaderText = "Price";
			this.Price.MinimumWidth = 6;
			this.Price.Name = "Price";
			// 
			// Quantity
			// 
			this.Quantity.HeaderText = "Quantity";
			this.Quantity.MinimumWidth = 6;
			this.Quantity.Name = "Quantity";
			// 
			// Total
			// 
			this.Total.HeaderText = "Total";
			this.Total.MinimumWidth = 6;
			this.Total.Name = "Total";
			// 
			// TxtBillNo
			// 
			this.TxtBillNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TxtBillNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtBillNo.Location = new System.Drawing.Point(1079, 375);
			this.TxtBillNo.Name = "TxtBillNo";
			this.TxtBillNo.Size = new System.Drawing.Size(161, 28);
			this.TxtBillNo.TabIndex = 30;
			// 
			// BtnAddBill
			// 
			this.BtnAddBill.BackColor = System.Drawing.Color.White;
			this.BtnAddBill.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnAddBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnAddBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnAddBill.ForeColor = System.Drawing.Color.Green;
			this.BtnAddBill.Location = new System.Drawing.Point(1279, 367);
			this.BtnAddBill.Name = "BtnAddBill";
			this.BtnAddBill.Size = new System.Drawing.Size(96, 40);
			this.BtnAddBill.TabIndex = 31;
			this.BtnAddBill.Text = "Add";
			this.BtnAddBill.UseVisualStyleBackColor = false;
			this.BtnAddBill.Click += new System.EventHandler(this.BtnAddBill_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(939, 376);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(129, 25);
			this.label3.TabIndex = 32;
			this.label3.Text = "Bill Number:";
			// 
			// FrmSales
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1387, 686);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.BtnAddBill);
			this.Controls.Add(this.TxtBillNo);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.dGridSearch);
			this.Controls.Add(this.BtnAddSales);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dGridSalesList);
			this.Controls.Add(this.BtnSearch);
			this.Controls.Add(this.BtnRefresh);
			this.Controls.Add(this.CmbCategory);
			this.Controls.Add(this.LblAmount);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.dGridSales);
			this.Controls.Add(this.BtnAddOrder);
			this.Controls.Add(this.TxtProduct);
			this.Controls.Add(this.TxtPrice);
			this.Controls.Add(this.TxtQty);
			this.Controls.Add(this.TxtID);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "FrmSales";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Product Sales";
			this.Load += new System.EventHandler(this.FrmSales_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dGridSales)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dGridSalesList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dGridSearch)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label LblDate;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox TxtID;
		private System.Windows.Forms.TextBox TxtQty;
		private System.Windows.Forms.TextBox TxtPrice;
		private System.Windows.Forms.TextBox TxtProduct;
		private System.Windows.Forms.Button BtnAddOrder;
		private System.Windows.Forms.DataGridView dGridSales;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label LblAmount;
		private System.Windows.Forms.Button BtnSearch;
		private System.Windows.Forms.Button BtnRefresh;
		private System.Windows.Forms.ComboBox CmbCategory;
		private System.Windows.Forms.DataGridView dGridSalesList;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button BtnAddSales;
		private System.Windows.Forms.DataGridView dGridSearch;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProID;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Price;
		private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
		private System.Windows.Forms.DataGridViewTextBoxColumn Total;
		private System.Windows.Forms.TextBox TxtBillNo;
		private System.Windows.Forms.Button BtnAddBill;
		private System.Windows.Forms.Label label3;
	}
}