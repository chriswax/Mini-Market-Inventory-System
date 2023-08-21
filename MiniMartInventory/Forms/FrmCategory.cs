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
	public partial class FrmCategory : Form
	{
		DBConnection dbConn = new DBConnection();
		public FrmCategory()
		{
			InitializeComponent();
		}

		private void FrmCategory_Load(object sender, EventArgs e)
		{
			BtnCategoryUpdate.Visible= false;
			BtnCategoryDelete.Visible= false;
			LblCatID.Visible= false;
			BindCategory();
		}

		private void BtnCategoryAdd_Click(object sender, EventArgs e)
		{
			if (TxtCatName.Text == String.Empty)
			{
				MessageBox.Show("Please Enter Category Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				TxtCatName.Focus();
				return;
			}
			else if (RchTxtCatDesc.Text == String.Empty)
			{
				MessageBox.Show("Please Enter Category Description", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				RchTxtCatDesc.Focus();
				return;
			}
			else
			{
				SqlCommand cmd = new SqlCommand("SELECT CatName FROM Category WHERE CatName=@CatName", dbConn.GetMyConn());
				cmd.Parameters.AddWithValue("@CatName", TxtCatName.Text.Trim());
				dbConn.OpenMyConn();
				var result = cmd.ExecuteScalar();

				if (result != null)
				{
					MessageBox.Show("Category Name Already Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					TxtClear();
				}
				else
				{
				cmd = new SqlCommand("spCatInsert", dbConn.GetMyConn());
				cmd.Parameters.AddWithValue("@CatName", TxtCatName.Text.Trim());
				cmd.Parameters.AddWithValue("@CatDesc", RchTxtCatDesc.Text.Trim());
				cmd.CommandType = CommandType.StoredProcedure;
				int i  = cmd.ExecuteNonQuery();
					if (i>0) {
						MessageBox.Show("Category Inserted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
						TxtClear();
						BindCategory();					
					}
				}
				dbConn.CloseMyConn();
			}
		}

		private void TxtClear()
		{
			TxtCatName.Clear();
			RchTxtCatDesc.Clear();
		}

		private void BindCategory()
		{
			SqlCommand cmd = new SqlCommand("SELECT CatID AS [Category ID], CatName AS [Category Name], CatDesc AS [Category Description] FROM Category", dbConn.GetMyConn());
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			da.Fill(dt);
			dGrdCategory.DataSource = dt;
			///dbConn.OpenMyConn();
		}

		private void dGrdCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}

		private void dGrdCategory_Click(object sender, EventArgs e)
		{
			BtnCategoryUpdate.Visible = true;
			BtnCategoryDelete.Visible = true;
			BtnCategoryAdd.Visible = false;
			LblCatID.Text = dGrdCategory.SelectedRows[0].Cells[0].Value.ToString();
			TxtCatName.Text = dGrdCategory.SelectedRows[0].Cells[1].Value.ToString();
			RchTxtCatDesc.Text = dGrdCategory.SelectedRows[0].Cells[2].Value.ToString();
		}

		private void BtnCategoryUpdate_Click(object sender, EventArgs e)
		{
			try
			{
				if (LblCatID.Text == String.Empty)
				{
					MessageBox.Show("Please Enter Category ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					TxtCatName.Focus();
					return;
				}
				if (TxtCatName.Text == String.Empty)
				{
					MessageBox.Show("Please Enter Category Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					TxtCatName.Focus();
					return;
				}
				else if (RchTxtCatDesc.Text == String.Empty)
				{
					MessageBox.Show("Please Enter Category Description", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					RchTxtCatDesc.Focus();
					return;
				}
				else
				{
					SqlCommand cmd = new SqlCommand("SELECT CatID FROM Category WHERE CatID=@CatID", dbConn.GetMyConn());
					cmd.Parameters.AddWithValue("@CatID", Convert.ToInt32(LblCatID.Text));
					dbConn.OpenMyConn();
					var result = cmd.ExecuteScalar();

					if (result == null)
					{
						MessageBox.Show("Category Name Does not Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						TxtClear();
					}
					else
					{
					    cmd = new SqlCommand("spCatUpdate", dbConn.GetMyConn());
						cmd.Parameters.AddWithValue("@CatID", Convert.ToInt32(LblCatID.Text));
						cmd.Parameters.AddWithValue("@CatName", TxtCatName.Text.Trim());
						cmd.Parameters.AddWithValue("@CatDesc", RchTxtCatDesc.Text.Trim());
						cmd.CommandType = CommandType.StoredProcedure;
						int i = cmd.ExecuteNonQuery();
						dbConn.CloseMyConn();
						if (i > 0)
						{
							MessageBox.Show("Category Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
							TxtClear();
							BindCategory();
							BtnCategoryUpdate.Visible = false;
							BtnCategoryDelete.Visible = false;
							BtnCategoryAdd.Visible = true;
							LblCatID.Visible = false;	
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

		private void BtnCategoryDelete_Click(object sender, EventArgs e)
		{
			try
			{
				if (LblCatID.Text == String.Empty)
				{
					MessageBox.Show("Please Enter Category ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				if (LblCatID.Text != String.Empty)
				{
					if (DialogResult.Yes == MessageBox.Show("Do you want to Delete", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
					{
						SqlCommand cmd = new SqlCommand("spCatDelete", dbConn.GetMyConn());
						cmd.Parameters.AddWithValue("@CatID", Convert.ToInt32(LblCatID.Text));
						cmd.CommandType = CommandType.StoredProcedure;
						dbConn.OpenMyConn();
						int i = cmd.ExecuteNonQuery();
						if (i > 0)
						{
							MessageBox.Show("Category Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
							TxtClear();
							BindCategory();
							BtnCategoryUpdate.Visible = false;
							BtnCategoryDelete.Visible = false;
							BtnCategoryAdd.Visible = true;
							LblCatID.Visible = false;
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
	}
}
