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

namespace MiniMartInventory.Forms
{
	public partial class FrmSeller : Form
	{
		DBConnection dbConn = new DBConnection();
		public FrmSeller()
		{
			InitializeComponent();
		}

		private void FrmSeller_Load(object sender, EventArgs e)
		{
			LblSellerID.Visible = false;
			BtnUpdate.Visible = false;
			BtnDelete.Visible = false;
			BindSeller();
		}

		private void BtnAdd_Click(object sender, EventArgs e)
		{
			if (TxtName.Text == String.Empty)
			{
				MessageBox.Show("Please Enter Seller's Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				TxtName.Focus();
				return;
			}
		   if (TxtPhone.Text == String.Empty)
			{
				MessageBox.Show("Please Enter Phone", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				TxtPassword.Focus();
				return;
			}
			else if (TxtPassword.Text == String.Empty)
			{
				MessageBox.Show("Please Enter Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				TxtPassword.Focus();
				return;
			}
			else
			{
				SqlCommand cmd = new SqlCommand("SELECT SellerName FROM Sales WHERE SellerName=@SellerName", dbConn.GetMyConn());
				cmd.Parameters.AddWithValue("@SellerName", TxtName.Text.Trim());
				dbConn.OpenMyConn();
				var result = cmd.ExecuteScalar();

				if (result != null)
				{
					MessageBox.Show("Seller Name Already Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					TxtClear();
				}
				else
				{

					cmd = new SqlCommand("spSalesInsert", dbConn.GetMyConn());
					cmd.Parameters.AddWithValue("@SellerName", TxtName.Text.Trim());
					cmd.Parameters.AddWithValue("@SellerAge", TxtAge.Text.Trim());
					cmd.Parameters.AddWithValue("@SellerPhone", TxtPhone.Text.Trim());
					cmd.Parameters.AddWithValue("@SellerPassword", TxtPassword.Text.Trim());
					cmd.CommandType = CommandType.StoredProcedure;
					int i = cmd.ExecuteNonQuery();
					if (i > 0)
					{
						MessageBox.Show("Seller Inserted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
						TxtClear();
						BindSeller();
					}
				}
				dbConn.CloseMyConn();
			}
		}

		private void BtnUpdate_Click(object sender, EventArgs e)
		{
			try
			{
				if (LblSellerID. Text == String.Empty)
				{
					MessageBox.Show("Please Enter Seller ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				if (TxtName.Text == String.Empty)
				{
					MessageBox.Show("Please Enter Seller Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					TxtName.Focus();
					return;
				}
				else if (TxtPassword.Text == String.Empty)
				{
					MessageBox.Show("Please Enter Seller", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					TxtPassword.Focus();
					return;
				}
				else
				{
					SqlCommand cmd = new SqlCommand("SELECT SellerID FROM Sales WHERE SellerID=@SellerID", dbConn.GetMyConn());
					cmd.Parameters.AddWithValue("@SellerName", Convert.ToInt32(TxtName.Text));
					dbConn.OpenMyConn();
					var result = cmd.ExecuteScalar();

					if (result == null)
					{
						MessageBox.Show("Error Occurred with the Id, Refresh", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						TxtClear();
					}
					else
					{
						cmd = new SqlCommand("spSalesUpdate", dbConn.GetMyConn());
						cmd.Parameters.AddWithValue("@SellerID", Convert.ToInt32(LblSellerID.Text));
						cmd.Parameters.AddWithValue("@SellerName", TxtName.Text.Trim());
						cmd.Parameters.AddWithValue("@SellerAge", TxtAge.Text.Trim());
						cmd.Parameters.AddWithValue("@SellerPhone", TxtPhone.Text.Trim());
						cmd.Parameters.AddWithValue("@SellerPassword", TxtPassword.Text.Trim());
						cmd.CommandType = CommandType.StoredProcedure;
						int i = cmd.ExecuteNonQuery();
						dbConn.CloseMyConn();
						if (i > 0)
						{
							MessageBox.Show("Seller Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
							TxtClear();
							BindSeller();
							BtnUpdate.Visible = false;
							BtnDelete.Visible = false;
							BtnAdd.Visible = true;
							LblSellerID.Visible = false;
						}
						else
						{
							MessageBox.Show("Update Failed...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
							TxtClear();
						}
					}
					dbConn.CloseMyConn();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void BtnDelete_Click(object sender, EventArgs e)
		{
			try
			{
				if (LblSellerID.Text == String.Empty)
				{
					MessageBox.Show("Please Enter Seller's ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				if (LblSellerID.Text != String.Empty)
				{
					if (DialogResult.Yes == MessageBox.Show("Do you want to Delete", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
					{
						SqlCommand cmd = new SqlCommand("spSalesDelete", dbConn.GetMyConn());
						cmd.Parameters.AddWithValue("@SellerID", Convert.ToInt32(LblSellerID.Text));
						cmd.CommandType = CommandType.StoredProcedure;
						dbConn.OpenMyConn();
						int i = cmd.ExecuteNonQuery();
						if (i > 0)
						{
							MessageBox.Show("Seller Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
							TxtClear();
							BindSeller();
							BtnUpdate.Visible = false;
							BtnDelete.Visible = false;
							BtnAdd.Visible = true;
							LblSellerID.Visible = false;
						}
						else
						{
							MessageBox.Show("Delete Failed...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
							TxtClear();
						}
						dbConn.CloseMyConn();
					}

				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void TxtClear()
		{
			TxtName.Clear();
			TxtPhone.Clear();
			TxtAge.Clear();
			TxtPassword.Clear();
		}

		private void BindSeller()
		{
			SqlCommand cmd = new SqlCommand("SELECT SellerID AS ID, SellerName AS Name, SellerAge AS Age, SellerPhone AS Phone, SellerPassword AS Password FROM Sales", dbConn.GetMyConn());
			dbConn.OpenMyConn();
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			da.Fill(dt);
			dGrid.DataSource = dt;
			dbConn.CloseMyConn();
		}

		private void dGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void dGrid_Click(object sender, EventArgs e)
		{
			BtnUpdate.Visible = true;
			BtnDelete.Visible = true;
			BtnAdd.Visible = false;
			LblSellerID.Text = dGrid.SelectedRows[0].Cells[0].Value.ToString();
			TxtName.Text = dGrid.SelectedRows[0].Cells[1].Value.ToString();
			TxtAge.Text = dGrid.SelectedRows[0].Cells[2].Value.ToString(); 
			TxtPhone.Text = dGrid.SelectedRows[0].Cells[3].Value.ToString();
			TxtPassword.Text = dGrid.SelectedRows[0].Cells[4].Value.ToString();
		}
	}
}
