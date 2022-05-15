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
    public partial class Doctors : Form
    {
        public Doctors()
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
        private void Doctors_Load(object sender, EventArgs e) // Вывод информации о докторах в таблицу
        {
            Connect("Select Doctors.ID, Doctors.Фамилия, Doctors.Имя, Doctors.Отчество, Doctors_specialization.Специализация from Doctors inner join Doctors_specialization ON Doctors.Специализация=Doctors_specialization.ID");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Connect("Select Doctors.ID, Doctors.Фамилия, Doctors.Имя, Doctors.Отчество, Doctors_specialization.Специализация from Doctors inner join Doctors_specialization ON Doctors.Специализация=Doctors_specialization.ID");
        }

        private void button3_Click(object sender, EventArgs e) // удаление, выбранной из таблицы, записи о докторах и последующее обновление информации в таблице
        {
            int rowindex = dataGridView1.CurrentCell.RowIndex;
            string id = dataGridView1.Rows[rowindex].Cells[0].Value.ToString();
            DialogResult result = MessageBox.Show("Удалить запись?", " Подтверждение удаления", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (SqlConnection connection = new SqlConnection(bd.connectionString))
                {
                    string sql = "DELETE FROM Doctors WHERE ID='" + id + "'";
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                Connect("Select Doctors.ID, Doctors.Фамилия, Doctors.Имя, Doctors.Отчество, Doctors_specialization.Специализация from Doctors inner join Doctors_specialization ON Doctors.Специализация=Doctors_specialization.ID");
            }
        }

        private void button1_Click(object sender, EventArgs e) // нажатие на кнопку добавления
        {
            AdminPanel.DoctorsAddEdit ad = new AdminPanel.DoctorsAddEdit();
            ad.options = "add";
            ad.Show();
        }

        private void button2_Click(object sender, EventArgs e) // редактирование выбранной строки, данные передаются на форму редактирования
        {
            AdminPanel.DoctorsAddEdit ad = new AdminPanel.DoctorsAddEdit();
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
