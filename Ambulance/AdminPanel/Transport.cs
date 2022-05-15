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
    public partial class Transport : Form
    {
        public Transport()
        {
            InitializeComponent();
        }
        DataBase bd = new DataBase();

        void Connect(string sql)
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
        private void Transport_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ambulanceDataSet2.Transports". При необходимости она может быть перемещена или удалена.
            this.transportsTableAdapter.Fill(this.ambulanceDataSet2.Transports);
            Connect("SELECT * FROM Transports");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridView1.CurrentCell.RowIndex;
            string number = dataGridView1.Rows[rowindex].Cells[1].Value.ToString();
            DialogResult result = MessageBox.Show("Удалить транспорт с номером " + number + "?", " Подтверждение удаления", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (SqlConnection connection = new SqlConnection(bd.connectionString))
                {
                    string sql = "DELETE FROM Transports WHERE Номер_Автомобиля='" + number + "'";
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                Connect("SELECT * FROM Transports");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TransportAddEdit ad = new TransportAddEdit();
            ad.options = "add";
            ad.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TransportAddEdit ad = new TransportAddEdit();
            ad.options = "edit";
            int rowindex = dataGridView1.CurrentCell.RowIndex;
            ad.ID1 = dataGridView1.Rows[rowindex].Cells[0].Value.ToString();
            ad.textBox1.Text = dataGridView1.Rows[rowindex].Cells[1].Value.ToString();
            ad.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Connect("SELECT * FROM Transports");
        }
    }
}
