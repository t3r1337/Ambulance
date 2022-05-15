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
    public partial class Paramedic : Form
    {
        public Paramedic()
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

        private void Paramedic_Load(object sender, EventArgs e)
        {
            Connect("SELECT * FROM Paramedic");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridView1.CurrentCell.RowIndex;
            string id = dataGridView1.Rows[rowindex].Cells[0].Value.ToString();
            DialogResult result = MessageBox.Show("Удалить запись?", " Подтверждение удаления", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (SqlConnection connection = new SqlConnection(bd.connectionString))
                {
                    string sql = "DELETE FROM Paramedic WHERE ID='" + id + "'";
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                Connect("SELECT * FROM Paramedic");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Connect("SELECT * FROM Paramedic");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ParamedicAddEdit ad = new ParamedicAddEdit();
            ad.options = "add";
            ad.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ParamedicAddEdit ad = new ParamedicAddEdit();
            ad.options = "edit";
            int rowindex = dataGridView1.CurrentCell.RowIndex;
            ad.ID1 = dataGridView1.Rows[rowindex].Cells[0].Value.ToString();
            ad.textBox1.Text = dataGridView1.Rows[rowindex].Cells[1].Value.ToString();
            ad.textBox2.Text = dataGridView1.Rows[rowindex].Cells[2].Value.ToString();
            ad.textBox3.Text = dataGridView1.Rows[rowindex].Cells[3].Value.ToString();
            ad.Show();
        }
    }
}
