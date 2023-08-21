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
	public partial class FrmProduct : Form
	{
		DBConnection dbConn = new DBConnection();
		public FrmProduct()
		{
			InitializeComponent();
		}

		private void CmbCat_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void FrmProduct_Load(object sender, EventArgs e)
		{
			BindCategory();
			BindProduct();
			SearchBy_Category();
			LblProductID.Visible = false;
			BtnAdd.Visible = true;
			BtnUpdate.Visible = false;
			BtnDelete.Visible = false;

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
				CmbCat.DataSource = dt;
				CmbCat.DisplayMember = "CatName";
				CmbCat.ValueMember = "CatID";
				dbConn.CloseMyConn();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void BtnAdd_Click(object sender, EventArgs e)
		{
			try
			{
				if (TxtName.Text == String.Empty)
				{
					MessageBox.Show("Please Enter Product's Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					TxtName.Focus();
					return;
				}
				else if(TxtQty.Text == String.Empty && Convert.ToInt32(TxtQty.Text) > 0)
				{
					MessageBox.Show("Please Enter Quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					TxtQty.Focus();
					return;
				}
				else if(TxtPrice.Text == String.Empty && Convert.ToInt32(TxtPrice.Text) > 0)
				{
					MessageBox.Show("Please Enter Product Price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					TxtPrice.Focus();
					return;
				}
				else
				{
					SqlCommand cmd = new SqlCommand("spCheckDuplicateProduct", dbConn.GetMyConn());
					cmd.Parameters.AddWithValue("@ProName", TxtName.Text);
					cmd.Parameters.AddWithValue("@ProCatID", CmbCat.SelectedValue);
					cmd.CommandType = CommandType.StoredProcedure;
					dbConn.OpenMyConn();
					var result = cmd.ExecuteScalar();

					if (result != null)
					{
						MessageBox.Show("Product Already Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						TxtClear();
					}
					else
					{
						cmd = new SqlCommand("spInsertProduct", dbConn.GetMyConn());
						cmd.Parameters.AddWithValue("@ProName", TxtName.Text);
						cmd.Parameters.AddWithValue("@ProCatID", CmbCat.SelectedValue);
						cmd.Parameters.AddWithValue("@ProPrice", Convert.ToDecimal(TxtPrice.Text));
						cmd.Parameters.AddWithValue("@ProQty", Convert.ToInt32(TxtQty.Text));
						cmd.CommandType = CommandType.StoredProcedure;
						int i = cmd.ExecuteNonQuery();
						if (i > 0)
						{
							MessageBox.Show("Product Inserted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
							TxtClear();
							BindProduct();
						}
					}
					dbConn.CloseMyConn();
				}
			}
			catch(Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		private void TxtClear()
		{
			TxtName.Clear();
			TxtPrice.Clear();
			TxtQty.Clear();
		}

		private void BindProduct()
		{
			try
			{
				SqlCommand cmd = new SqlCommand("spGetAllProduct", dbConn.GetMyConn());
				cmd.CommandType = CommandType.StoredProcedure;
				dbConn.OpenMyConn();
				SqlDataAdapter da = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				da.Fill(dt);
				dGrid.DataSource = dt;
				dbConn.CloseMyConn();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		

		private void SearchBy_Category()
		{
			try
			{
				SqlCommand cmd = new SqlCommand("spGetCategory", dbConn.GetMyConn());
				cmd.CommandType = CommandType.StoredProcedure;
				dbConn.OpenMyConn();
				SqlDataAdapter da = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				da.Fill(dt);
				CmbSearch.DataSource = dt;
				CmbSearch.DisplayMember = "CatName";
				CmbSearch.ValueMember = "CatID";
				dbConn.CloseMyConn();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void BtnUpdate_Click(object sender, EventArgs e)
		{
			try
			{
				if (LblProductID.Text == "" || TxtName.Text == String.Empty)
				{
					MessageBox.Show("Please Enter Product Name and ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					TxtName.Focus();
					return;
				}
				else if (TxtQty.Text == String.Empty && Convert.ToInt32(TxtQty.Text) > 0)
				{
					MessageBox.Show("Please Enter Quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					TxtQty.Focus();
					return;
				}
				else if (TxtPrice.Text == String.Empty && Convert.ToInt32(TxtPrice.Text) > 0)
				{
					MessageBox.Show("Please Enter Product Price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					TxtPrice.Focus();
					return;
				}
				else
				{
					SqlCommand cmd = new SqlCommand("spCheckDuplicateProduct", dbConn.GetMyConn());
					cmd.Parameters.AddWithValue("@ProName", TxtName.Text);
					cmd.Parameters.AddWithValue("@ProCatID", CmbCat.SelectedValue);
					cmd.CommandType = CommandType.StoredProcedure;
					dbConn.OpenMyConn();
					var result = cmd.ExecuteNonQuery();

					if (result > 1)
					{
						MessageBox.Show("Error Occurred...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						TxtClear();
					}
					else
					{
						cmd = new SqlCommand("spUpdateProduct", dbConn.GetMyConn());
						cmd.Parameters.AddWithValue("@ProID", Convert.ToInt32(LblProductID.Text));
						cmd.Parameters.AddWithValue("@ProName", TxtName.Text);
						cmd.Parameters.AddWithValue("@ProCatID", CmbCat.SelectedValue);
						cmd.Parameters.AddWithValue("@ProPrice", Convert.ToDecimal(TxtPrice.Text));
						cmd.Parameters.AddWithValue("@ProQty", Convert.ToInt32(TxtQty.Text));
						cmd.CommandType = CommandType.StoredProcedure;
						int i = cmd.ExecuteNonQuery();
						if (i > 0)
						{
							MessageBox.Show("Product Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
							TxtClear();
							BindProduct();
							BtnUpdate.Visible = false;
							BtnDelete.Visible = false;
							BtnAdd.Visible = true;
							LblProductID.Visible = false;
						}
						else
						{
							MessageBox.Show("Updation Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
					dbConn.CloseMyConn();
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void BtnDelete_Click(object sender, EventArgs e)
		{
			try
			{
				if (LblProductID.Text == String.Empty)
				{
					MessageBox.Show("Error Occurred, Product ID Not seen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				if (LblProductID.Text != String.Empty)
				{
					if (DialogResult.Yes == MessageBox.Show("Do you want to Delete", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
					{
						SqlCommand cmd = new SqlCommand("spDeleteProduct", dbConn.GetMyConn());
						cmd.Parameters.AddWithValue("@ProID", Convert.ToInt32(LblProductID.Text));
						cmd.CommandType = CommandType.StoredProcedure;
						dbConn.OpenMyConn();
						int i = cmd.ExecuteNonQuery();
						if (i > 0)
						{
							MessageBox.Show("Seller Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
							TxtClear();
							BindProduct();
							BtnUpdate.Visible = false;
							BtnDelete.Visible = false;
							BtnAdd.Visible = true;
							LblProductID.Visible = false;
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
			catch(Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void dGrid_Click(object sender, EventArgs e)
		{
			try
			{
				BtnUpdate.Visible = true;
				BtnDelete.Visible = true;
				BtnAdd.Visible = false;
				LblProductID.Visible=false;

				LblProductID.Text = dGrid.SelectedRows[0].Cells[0].Value.ToString();
				TxtName.Text = dGrid.SelectedRows[0].Cells[1].Value.ToString();
				CmbCat.SelectedValue = dGrid.SelectedRows[0].Cells[3].Value.ToString();
				TxtPrice.Text = dGrid.SelectedRows[0].Cells[4].Value.ToString();
				TxtQty.Text = dGrid.SelectedRows[0].Cells[5].Value.ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void CmbSearch_SelectedIndexChanged(object sender, EventArgs e)
		{
			//Searched_ProductList();   //uncoumment to automatically search on select of category
		}

		private void Searched_ProductList()
		{
			try
			{
				SqlCommand cmd = new SqlCommand("spSearchProductByCategory", dbConn.GetMyConn());
				cmd.Parameters.AddWithValue("@ProCatID", CmbSearch.SelectedValue);
				cmd.CommandType = CommandType.StoredProcedure;
				dbConn.OpenMyConn();
				SqlDataAdapter da = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				da.Fill(dt);
				dGrid.DataSource = dt;
				dbConn.CloseMyConn();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void BtnRefresh_Click(object sender, EventArgs e)
		{
			BindProduct();
		}

		private void BtnSearch_Click(object sender, EventArgs e)
		{
			Searched_ProductList();
		}
	}
}
