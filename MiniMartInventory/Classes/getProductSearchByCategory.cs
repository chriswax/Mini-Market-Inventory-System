using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniMartInventory.Classes
{
	internal class getProductSearchByCategory
	{
		DBConnection dbConn = new DBConnection();
		private void Searched_ProductList(string CmbData, string dGrid)
		{
			try
			{
				SqlCommand cmd = new SqlCommand("spSearchProductByCategory", dbConn.GetMyConn());
				cmd.Parameters.AddWithValue("@ProCatID", CmbData);
				cmd.CommandType = CommandType.StoredProcedure;
				dbConn.OpenMyConn();
				SqlDataAdapter da = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				da.Fill(dt);
				//dGrid.DataSource = dt;
				dbConn.CloseMyConn();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
