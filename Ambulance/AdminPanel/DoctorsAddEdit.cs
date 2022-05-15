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

namespace Ambulance.AdminPanel
{
    public partial class DoctorsAddEdit : Form
    {
        public DoctorsAddEdit()
        {
            InitializeComponent();
        }
        public string options;
        public string ID1;
        DataBase bd = new DataBase();
        void Connect(string sql)
        {
            using (SqlConnection connection = new SqlConnection(bd.connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        void select(string sql)
        {
            using (SqlConnection connection = new SqlConnection(bd.connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                connection.Close();
            }
        }

        private void DoctorsAddEdit_Load(object sender, EventArgs e)
        {
            select("SELECT * FROM Doctors_specialization");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (options == "add") // операция добавления
            {
                Connect("INSERT INTO Doctors (Фамилия, Имя, Отчество, Специализация) VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "')");
                MessageBox.Show("Данные добавлены");
                this.Close();
            }
            if (options == "edit") // операция редактирования
            {
                Connect("UPDATE Doctors SET Фамилия='" + textBox1.Text + "', Имя='" + textBox2.Text + "', Отчество='" + textBox3.Text + "', Специализация='" + textBox4.Text + "' WHERE ID ='" + ID1 + "' ");
                MessageBox.Show("Изменены добавлены");
                this.Close();
            }
        }
    }
}
