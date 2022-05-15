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
    public partial class TransportAddEdit : Form
    {
        public TransportAddEdit()
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
                Connect("INSERT INTO Transports (Номер_Автомобиля) VALUES ('" + textBox1.Text + "')");
                MessageBox.Show("Данные добавлены");
                this.Close();
            }
            if (options == "edit")
            {
                Connect("UPDATE Transports SET Номер_Автомобиля = '" + textBox1.Text + "' WHERE ID ='" + ID1 +"' ");
                MessageBox.Show("Изменены добавлены");
                this.Close();
            }
        }
    }
}
