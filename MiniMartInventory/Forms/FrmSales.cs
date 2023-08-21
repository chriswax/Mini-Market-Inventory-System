using MiniMartInventory.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MiniMartInventory.Forms
{
	public partial class FrmSales : Form
	{
		DBConnection dbConn = new DBConnection();
		public FrmSales()
		{
			InitializeComponent();
		}
		double GrandTotal = 0.0, Amount; 
		int num = 0;	
		private void FrmSales_Load(object sender, EventArgs e)
		{
			BindCategory();
			LblDate.Text = DateTime.Now.ToShortDateString();
			BindBillList();
			//TxtBillNo.Text = Convert.ToString(getRandomNum());
			TxtBillNo.Text = Convert.ToString(getRandomNum());


		}
		private void BindCategory()
		{
			try
			{
				SqlCommand cmd = new SqlCommand("spGetCategory", dbConn.GetMyConn());
				cmd.CommandType = CommandType.StoredProcedure;
				dbConn.OpenMyConn();
				SqlDataAdapter da = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				da.Fill(dt);
				CmbCategory.DataSource = dt;
				CmbCategory.DisplayMember = "CatName";
				CmbCategory.ValueMember = "CatID";
				dbConn.CloseMyConn();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Searched_ProductList()
		{
			try
			{
				SqlCommand cmd = new SqlCommand("spSearchProductByCategory", dbConn.GetMyConn());
				cmd.Parameters.AddWithValue("@ProCatID", CmbCategory.SelectedValue);
				cmd.CommandType = CommandType.StoredProcedure;
				dbConn.OpenMyConn();
				SqlDataAdapter da = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				da.Fill(dt);
				dGridSearch.DataSource = dt;
				dbConn.CloseMyConn();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void BtnSearch_Click(object sender, EventArgs e)
		{
			Searched_ProductList();
		}

		private void BtnAddOrder_Click(object sender, EventArgs e)
		{
			try
			{
				if (TxtPrice.Text == "" || TxtQty.Text=="")
				{
					MessageBox.Show("Enter valid Qty or Price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
				else
				{
				double Total = Convert.ToDouble(TxtPrice.Text) * Convert.ToInt32(TxtQty.Text);
				DataGridViewRow addRow = new DataGridViewRow();
				addRow.CreateCells(dGridSales);
				addRow.Cells[0].Value = ++num;
				addRow.Cells[1].Value = TxtProduct.Text;
				addRow.Cells[2].Value = TxtPrice.Text;
				addRow.Cells[3].Value = TxtQty.Text;
				addRow.Cells[4].Value = Total;
				dGridSales.Rows.Add(addRow);
				GrandTotal += Total;
				LblAmount.Text = "N "+ GrandTotal;
				}
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void BtnAddBill_Click(object sender, EventArgs e)
		{
			try
			{
				if (TxtBillNo.Text == "")
				{
					MessageBox.Show("Enter Bill No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					SqlCommand cmd = new SqlCommand("spInsertBill", dbConn.GetMyConn());
					cmd.Parameters.AddWithValue("@BillID", TxtBillNo.Text);
					cmd.Parameters.AddWithValue("@SellerID", FrmLogin.LoginName);
					cmd.Parameters.AddWithValue("@SellerDate", LblDate.Text);
					cmd.Parameters.AddWithValue("@TotalAmount", Convert.ToDouble(TxtQty.Text));
					cmd.CommandType = CommandType.StoredProcedure;
					dbConn.OpenMyConn();
					int i = cmd.ExecuteNonQuery();
					if (i > 0)
					{
						BindBillList();
						TxtBillNo.Text = Convert.ToString(getRandomNum());
						MessageBox.Show("Bill Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					dbConn.CloseMyConn();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void ClrTxt()
		{
			TxtBillNo.Clear();
			dGridSales.DataSource = null;
			TxtPrice.Clear();
			TxtProduct.Clear();	
			TxtQty.Clear();
			TxtID.Clear();
			LblAmount.Text = "0.0";
		}
		private void BindBillList()
		{
			try
			{
				SqlCommand cmd = new SqlCommand("spGetBillList", dbConn.GetMyConn());
				cmd.CommandType = CommandType.StoredProcedure;
				dbConn.OpenMyConn();
				SqlDataAdapter da = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				da.Fill(dt);
				dGridSalesList.DataSource = dt;
				dbConn.CloseMyConn();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void dGridSearch_Click(object sender, EventArgs e)
		{
			try
			{
				TxtID.Clear();
				TxtID.Text = dGridSearch.SelectedRows[0].Cells[0].Value.ToString();
				TxtProduct.Clear();
				TxtProduct.Text = dGridSearch.SelectedRows[0].Cells[1].Value.ToString();
				TxtPrice.Clear();
				TxtPrice.Text = dGridSearch.SelectedRows[0].Cells[4].Value.ToString();
				//TxtQty.Text = dGridSearch.SelectedRows[0].Cells[5].Value.ToString();
				TxtQty.Clear();
				TxtQty.Focus();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	
		//private void getRandomNum()
		//{
		//	Random rnd = new Random();
		//	int generatedNum = rnd.Next();
		//}

		private int getRandomNum()
		{
			Random rnd = new Random();
			int generatedNum = rnd.Next();
			return generatedNum;
		}

	}
}
