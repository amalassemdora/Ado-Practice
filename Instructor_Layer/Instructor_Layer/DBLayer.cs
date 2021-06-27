using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Instructor_Layer
{
	class DBLayer
	{
		static SqlConnection con;
		static SqlCommand cmd;

		// Static Ctor
		static DBLayer()
		{
			con = new SqlConnection(@"Data Source=DESKTOP-QME387U\MSSQLSERVER01;Initial Catalog=ITI;Integrated Security=True");
			cmd = new SqlCommand();
			cmd.Connection = con;
		}
		
		public static DataTable Select(string query)
		{
			cmd.CommandText = query;
			SqlDataAdapter adapt = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			adapt.Fill(dt);
			return dt;
		}

		public static int DML(string query)
		{
			cmd.CommandText = query;
			con.Open();
			int RowAffected = cmd.ExecuteNonQuery();
			con.Close();
			return RowAffected;
		}

	}
}
