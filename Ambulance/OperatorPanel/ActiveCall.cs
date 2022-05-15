using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;

namespace Ambulance
{

    public partial class ActiveCall : Form
    {
        string Active = "Завершен";
        string stat = "Свободна";
        DataBase bd = new DataBase();
        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "w1oHZasmOqLnd0qigfvu9re3kqi7Na88FieWg93d",
            BasePath = "https://ambulance-21cbf-default-rtdb.europe-west1.firebasedatabase.app/"
        };
        IFirebaseClient Patient;
        void ActiveCallsql(string sql)
        {
            using (SqlConnection connection = new SqlConnection(bd.connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                ActiveCallView.DataSource = ds.Tables[0];
                connection.Close();
            }
        }

        public ActiveCall()
        {
            InitializeComponent();
        }

        private void ActiveCall_Load(object sender, EventArgs e)
        {
            ActiveCallsql("Select ID AS 'Номер вызова', Фамилия, Имя, Отчество, Возраст, Бригада, Статус_вызова AS 'Статус вызова' from Doctor_call Where Статус_вызова Like 'Выполняется'");
            try
            {
                Patient = new FireSharp.FirebaseClient(ifc);
            }
            catch
            {
                MessageBox.Show("Проблемы с интернетом");
            }
            load();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rowindex = ActiveCallView.CurrentCell.RowIndex;
            string id = ActiveCallView.Rows[rowindex].Cells[0].Value.ToString();
            using (SqlConnection connection = new SqlConnection(bd.connectionString))
            {
                string sql = "UPDATE Doctor_call SET Статус_вызова='" + Active + "' WHERE ID='" + id + "'";
                connection.Open();
                string acc1 = "Select Бригада from Doctor_call WHERE ID='" + id + "'";
                SqlCommand command = new SqlCommand(sql, connection);
                SqlCommand command1 = new SqlCommand(acc1, connection);
                command.ExecuteNonQuery();
                string IDstat = command1.ExecuteScalar().ToString();
                string sql1 = "UPDATE Brigades SET Статус='" + stat + "' WHERE ID='" + IDstat + "'";
                SqlCommand command2 = new SqlCommand(sql1, connection);
                command2.ExecuteNonQuery();
                connection.Close();
            }
            ActiveCallsql("Select ID AS Номер, Фамилия, Имя, Отчество, Возраст, Статус_вызова from Doctor_call Where Статус_вызова Like 'Выполняется'");
        }

       
        public void load() // Вывод Фамилии, имени, отчества, возраства и статуса вызова в DataGridView
        {
            FirebaseResponse res = Patient.Get("Calls/");
            Dictionary<string, Calls> getPatients = res.ResultAs<Dictionary<string, Calls>>();

            foreach (var get in getPatients)
            {
                FirebaseView.Rows.Add(
                    get.Value.Lastname,
                    get.Value.Firstname,
                    get.Value.Secondname,
                    get.Value.Age,
                    get.Value.Status
                    ); 
            }
        }
       
    }
}
