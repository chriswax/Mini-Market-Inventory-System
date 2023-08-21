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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MiniMartInventory
{
	public partial class FrmAdmin : Form
	{
		DBConnection dbConn = new DBConnection();
		public FrmAdmin()
		{
			InitializeComponent();
		}

		private void FrmAdmin_Load(object sender, EventArgs e)
		{			
			BtnUpdate.Visible = false;
			BtnDelete.Visible = false;
			BtnAdd.Visible = true;
			TxtName.Focus();
			BindAdmin();
		}

		private void BtnAdd_Click(object sender, EventArgs e)
		{
			if (TxtName.Text == string.Empty || TxtUsername.Text == string.Empty || TxtPassword.Text == string.Empty)
			{
				MessageBox.Show("Enter all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				clearField();
				TxtName.Focus();
				return;
			}
			else
			{
				//check for duplicate record
				SqlCommand cmd = new SqlCommand("SELECT USername FROM Admin WHERE Username=@Username", dbConn.GetMyConn());
				cmd.Parameters.AddWithValue("@Username", TxtName.Text);
				dbConn.OpenMyConn();
				var result = cmd.ExecuteScalar();
				if (result != null)
				{
					MessageBox.Show("Admin UserName Already Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					clearField();
				}
				else {
					cmd = new SqlCommand("spAdminInsert", dbConn.GetMyConn());
					cmd.Parameters.AddWithValue("@Fullname", TxtName.Text.Trim());
					cmd.Parameters.AddWithValue("@Username", TxtUsername.Text.Trim());
					cmd.Parameters.AddWithValue("@Password", TxtPassword.Text.Trim());
					cmd.CommandType = CommandType.StoredProcedure;
					int i = cmd.ExecuteNonQuery();
					if (i > 0)
					{
						MessageBox.Show("Admin Inserted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
						clearField();
						BindAdmin();
					}
				}
				dbConn.CloseMyConn();
			}
		}


		private void clearField()
		{
			TxtName.Clear();
			TxtUsername.Clear();
			TxtPassword.Clear();
		}
		private void BindAdmin()
		{
			SqlCommand cmd = new SqlCommand("SELECT * FROM Admin", dbConn.GetMyConn());
			//dbConn.OpenMyConn();
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			da.Fill(dt);
			dGrid.DataSource = dt;
			//dbConn.CloseMyConn();
		}

		private void BtnUpdate_Click(object sender, EventArgs e)
		{
			try
			{
				if (TxtName.Text == string.Empty || TxtUsername.Text == string.Empty || TxtPassword.Text == string.Empty)
				{
					MessageBox.Show("Enter all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					clearField();
					//return;
				}
				else
				{
					//check for duplicate record
					//SqlCommand cmd = new SqlCommand("SELECT Username FROM Admin WHERE Username=@Username", dbConn.GetMyConn());
					//cmd.Parameters.AddWithValue("@Username", TxtName.Text);
					//dbConn.OpenMyConn();
					//var result = cmd.ExecuteScalar();
					//if (result == null)
					//{
					//	MessageBox.Show("Admin UserName Already Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					//	clearField();
					//}
					//else
					//{
						SqlCommand cmd = new SqlCommand("spAdminUpdate", dbConn.GetMyConn());
						dbConn.OpenMyConn();
						cmd.Parameters.AddWithValue("@FullName", TxtName.Text);
						cmd.Parameters.AddWithValue("@Username", TxtUsername.Text); 
						cmd.Parameters.AddWithValue("@AdminID", LblAdminID.Text);
					cmd.Parameters.AddWithValue("@Password", TxtPassword.Text);
						cmd.CommandType = CommandType.StoredProcedure;
						int i = cmd.ExecuteNonQuery();
						dbConn.CloseMyConn();
						if (i > 0)
						{
							MessageBox.Show("Admin record Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
							clearField();
							BindAdmin();
						}
					//}
					
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
				if (TxtName.Text == string.Empty)
				{
					MessageBox.Show("Please Select Username", "Success", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				//if (TxtUsername.Text != string.Empty)
				else
				{
					if (DialogResult.Yes == MessageBox.Show("Do you want to Delete", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
					{
						SqlCommand cmd = new SqlCommand("spAdminDelete", dbConn.GetMyConn());
						cmd.Parameters.AddWithValue("@Username", TxtUsername.Text);
						cmd.CommandType = CommandType.StoredProcedure;
						dbConn.OpenMyConn();
						int i = cmd.ExecuteNonQuery();
						if (i > 0)
						{
							MessageBox.Show("Admin Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
							clearField();
							BindAdmin();
							BtnUpdate.Visible = false;
							BtnDelete.Visible = false;
							BtnAdd.Visible = true;
							LblAdminID.Visible = false;
						}
						else
						{
							MessageBox.Show("Delete Failed...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
							clearField();
						}
						dbConn.CloseMyConn();
					}
				}
			}
			catch(Exception ex) 
			{
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
				LblAdminID.Text = dGrid.SelectedRows[0].Cells[0].Value.ToString();
				TxtUsername.Text = dGrid.SelectedRows[0].Cells[0].Value.ToString();
				TxtName.Text = dGrid.SelectedRows[0].Cells[1].Value.ToString();
				TxtPassword.Text = dGrid.SelectedRows[0].Cells[2].Value.ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}


		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}
	}
}
