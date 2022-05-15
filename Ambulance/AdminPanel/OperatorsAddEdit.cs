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
    public partial class OperatorsAddEdit : Form
    {
        public OperatorsAddEdit()
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
                Connect("INSERT INTO Operators (Login, Password, Lastname, Firstname, Secondname, Role) VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "', '" + RoleCB.Text + "')");
                MessageBox.Show("Данные добавлены");
                this.Close();
            }
            if (options == "edit")
            {
                Connect("UPDATE Operators SET Login='" + textBox1.Text + "', Password='" + textBox2.Text + "', Lastname='" + textBox3.Text + "', Firstname='" + textBox4.Text + "', Secondname='" + textBox5.Text + "', Role='" + RoleCB.Text + "' WHERE ID ='" + ID1 + "' ");
                MessageBox.Show("Изменены добавлены");
                this.Close();
            }
        }
    }
}
