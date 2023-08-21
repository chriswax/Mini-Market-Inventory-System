using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MiniMartInventory.Classes
{
	internal class DBConnection
	{
		private SqlConnection MyConn =  new SqlConnection(@"Data Source=CHRISWAX-ICTD;Initial Catalog=MiniMartInventory;Integrated Security=True");
		public SqlConnection GetMyConn() 
		{ 
			return MyConn;
		}
		public void OpenMyConn()
		{
			if(MyConn.State == ConnectionState.Closed)
			{
				MyConn.Open();
			}
		}
		public void CloseMyConn()
		{
			if (MyConn.State == ConnectionState.Open)
			{
				MyConn.Close();
			}
		}
	
	}
}
