using MiniMartInventory.Classes;
using MiniMartInventory.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniMartInventory
{
	public partial class FrmLogin : Form
	{
		DBConnection dbConn = new DBConnection();
		public static string LoginName, LoginType;
		public FrmLogin()
		{
			InitializeComponent();
		}

		private void FrmLogin_Load(object sender, EventArgs e)
		{
			CmbRole.SelectedIndex = 0;
		}

		private void BtnLogin_Click(object sender, EventArgs e)
		{
			try
			{
				if (CmbRole.SelectedIndex > 0 ) {
					if (TxtUsername.Text == String.Empty)
					{
						MessageBox.Show("Please Enter Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						TxtUsername.Focus();
						return;
					}
					if (TxtPassword.Text == String.Empty)
					{
						MessageBox.Show("Please Enter Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						TxtPassword.Focus();
						return;
					}
					if (CmbRole.SelectedIndex > 0 && TxtUsername.Text != String.Empty && TxtPassword.Text != String.Empty)
					{
						//login code
						if (CmbRole.Text == "Admin" || CmbRole.Text == "Accountant")
						{
							SqlCommand cmd = new SqlCommand("SELECT TOP 1 Username, Password, FullName FROM Admin WHERE Username=@Username AND Password=@Password", dbConn.GetMyConn());
							cmd.Parameters.AddWithValue("@Username", TxtUsername.Text.Trim());
							cmd.Parameters.AddWithValue("@Password", TxtPassword.Text.Trim());
							dbConn.OpenMyConn();
							SqlDataAdapter da = new SqlDataAdapter(cmd);
							DataTable dt = new DataTable();
							da.Fill(dt);
							if (dt.Rows.Count > 0)
							{
								MessageBox.Show("Login Success Welcome to Home Page", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
								LoginName = TxtUsername.Text;
								LoginType= CmbRole.Text;
								ClearValue();
								this.Hide();
								FrmMain frmMain = new FrmMain();
								frmMain.Show();
							}
							else
							{
								MessageBox.Show("Invalid Login Please check Username and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
							}
						}
						else if (CmbRole.Text == "Sales")
						{
							SqlCommand cmd = new SqlCommand("SELECT TOP 1 SellerName, SellerPassword FROM Sales WHERE SellerName = @SellerName AND SellerPassword = @SellerPassword", dbConn.GetMyConn());
							cmd.Parameters.AddWithValue("@SellerName", TxtUsername.Text.Trim());
							cmd.Parameters.AddWithValue("@SellerPassword", TxtPassword.Text.Trim());
							dbConn.OpenMyConn();
							SqlDataAdapter da = new SqlDataAdapter(cmd);
							DataTable dt = new DataTable();
							da.Fill(dt);
							if (dt.Rows.Count > 0)
							{
								MessageBox.Show("Login Success Welcome to Home Page", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
								LoginName = TxtUsername.Text;
								LoginType = CmbRole.Text;
								ClearValue();
								this.Hide();
								FrmMain frmMain = new FrmMain();
								frmMain.Show();
							}
							else
							{
								MessageBox.Show("Invalid Login Please check Username and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
							}
						}


					}
					else
					{
						MessageBox.Show("Please Enter Username and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						ClearValue();
					}
				}
				else
				{
					MessageBox.Show("Please Select Role", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					ClearValue();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

	
		private void BtnClear_Click(object sender, EventArgs e)
		{
			ClearValue();
		}

		private void ClearValue()
		{
			CmbRole.SelectedIndex = 0;
			TxtUsername.Clear();
			TxtPassword.Clear();
		}
	
	}
}
