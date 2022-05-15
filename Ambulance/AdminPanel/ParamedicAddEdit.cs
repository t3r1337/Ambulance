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
    public partial class ParamedicAddEdit : Form
    {
        public ParamedicAddEdit()
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
        private void button1_Click(object sender, EventArgs e)
        {
            if (options == "add")
            {
                Connect("INSERT INTO Paramedic (Фамилия, Имя, Отчество) VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "')");
                MessageBox.Show("Данные добавлены");
                this.Close();
            }
            if (options == "edit")
            {
                Connect("UPDATE Paramedic SET Фамилия='" + textBox1.Text + "', Имя='" + textBox2.Text + "', Отчество='" + textBox3.Text + "' WHERE ID ='" + ID1 + "' ");
                MessageBox.Show("Изменены добавлены");
                this.Close();
            }
        }
    }
}
