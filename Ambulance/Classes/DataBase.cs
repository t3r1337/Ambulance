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

namespace Ambulance
{
    class DataBase
    {
        SqlConnection con = new SqlConnection(@"Data Source=ZXC123\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=Ambulance");
        public string connectionString = (@"Data Source=ZXC123\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=Ambulance");
        
        public void Connect(string sql)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                connection.Close();
            }
        }
 
        public void openConnection()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public void closeConnection()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
        public SqlConnection getConnection()
        {
            return con;
        }
    }
}
