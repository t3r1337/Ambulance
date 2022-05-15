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
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;

namespace Ambulance
{
    public partial class DoctorCall : Form
    {
        public string operID;
        string stat = "Занята";
        DataBase bd = new DataBase();
        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "w1oHZasmOqLnd0qigfvu9re3kqi7Na88FieWg93d",
            BasePath = "https://ambulance-21cbf-default-rtdb.europe-west1.firebasedatabase.app/"
        };
        IFirebaseClient Patient;
        public void FreeBrigades(string sql)
        {
            using (SqlConnection connection = new SqlConnection(bd.connectionString))
            {;
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                BrigadesView.DataSource = ds.Tables[0];
                connection.Close();
            }
        }
        public DoctorCall()
        {
            InitializeComponent();
        }

        DataBase db = new DataBase();
        string Status = "Выполняется";
        private void button1_Click(object sender, EventArgs e)
        {
            db.Connect("INSERT INTO Doctor_call (Фамилия, Имя, Отчество, Возраст, Адрес, Телефон, Дата_вызова, Время, Бригада, Повод_вызова, Статус_вызова, Оператор) VALUES ('" + LastnameTB.Text + "', '" + FirstnameTB.Text + "', '" + SecondnameTB.Text + "', '" + AgeTB.Text + "', '" + AddressTB.Text + "', '" + TelephoneTB.Text + "', '" + DateTime.Today.ToString() + "', '" + DateTime.Now.ToLongTimeString() + "', '" + BrigadesCB.Text + "', '" + SituathionTB.Text + "', '" + Status + "', '" + operID + "')");
            Calls call = new Calls() // Добавление нового вызова
            {
                Lastname = LastnameTB.Text,
                Firstname = FirstnameTB.Text,
                Secondname = SecondnameTB.Text,
                Adress = AddressTB.Text,
                Brigade_number = BrigadesCB.Text,
                Age = AgeTB.Text,
                Date = DateTime.Today.ToLongDateString(),
                Time = DateTime.Now.ToLongTimeString(),
                Status = Status,
                Description = SituathionTB.Text,
                Phone = TelephoneTB.Text
            };
            var setter = Patient.Set("Calls/" + TelephoneTB.Text, call);
            using (SqlConnection connection = new SqlConnection(bd.connectionString))
            {
                connection.Open();
                string acc1 = BrigadesCB.Text;
                SqlCommand command1 = new SqlCommand(acc1, connection);
                string sql1 = "UPDATE Brigades SET Статус='" + stat + "' WHERE ID='" + acc1 + "'";
                SqlCommand command2 = new SqlCommand(sql1, connection);
                command2.ExecuteNonQuery();
                connection.Close();
            }
            MessageBox.Show("Регистрация успешна");

        }

        private void DoctorCall_Load(object sender, EventArgs e)
        {
            FreeBrigades("Select Brigades.ID AS 'Номер бригады', Brigades_specialization.Специализация from Brigades inner join Brigades_specialization ON Brigades.Специализация_бригады=Brigades_specialization.ID Where Brigades.Статус Like 'Свободна'");
            //FreeBrigades("Select * from brigades");
            try
            {
                Patient = new FireSharp.FirebaseClient(ifc);
            }
            catch
            {
                MessageBox.Show("Проблемы с интернетом");

            }
        }
    }
}
