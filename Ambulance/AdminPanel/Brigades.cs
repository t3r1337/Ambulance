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
    public partial class Brigades : Form
    {
        public Brigades()
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

        private void Brigades_Load(object sender, EventArgs e)
        {
            Connect("Select Brigades.ID AS 'Номер бригады', Orderlies.Фамилия AS 'Санитар', Paramedic.Фамилия AS 'Фельдшер', Doctors.Фамилия AS 'Доктор', Transports.Номер_Автомобиля AS 'Транспорт', Brigades_specialization.Специализация from Brigades inner join Brigades_specialization ON Brigades.Специализация_бригады=Brigades_specialization.ID inner join Orderlies ON Brigades.Санитар=Orderlies.ID inner join Paramedic ON Brigades.Фельдшер=Paramedic.ID inner join Doctors ON Brigades.Доктор=Doctors.ID Inner join Transports ON Brigades.Транспорт=Transports.ID");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Connect("Select Brigades.ID AS 'Номер бригады', Orderlies.Фамилия AS 'Санитар', Paramedic.Фамилия AS 'Фельдшер', Doctors.Фамилия AS 'Доктор', Transports.Номер_Автомобиля AS 'Транспорт', Brigades_specialization.Специализация from Brigades inner join Brigades_specialization ON Brigades.Специализация_бригады=Brigades_specialization.ID inner join Orderlies ON Brigades.Санитар=Orderlies.ID inner join Paramedic ON Brigades.Фельдшер=Paramedic.ID inner join Doctors ON Brigades.Доктор=Doctors.ID Inner join Transports ON Brigades.Транспорт=Transports.ID");
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
                    string sql = "DELETE FROM Brigades WHERE ID='" + id + "'";
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                Connect("Select Brigades.ID AS 'Номер бригады', Orderlies.Фамилия AS 'Санитар', Paramedic.Фамилия AS 'Фельдшер', Doctors.Фамилия AS 'Доктор', Transports.Номер_Автомобиля AS 'Транспорт', Brigades_specialization.Специализация from Brigades inner join Brigades_specialization ON Brigades.Специализация_бригады=Brigades_specialization.ID inner join Orderlies ON Brigades.Санитар=Orderlies.ID inner join Paramedic ON Brigades.Фельдшер=Paramedic.ID inner join Doctors ON Brigades.Доктор=Doctors.ID Inner join Transports ON Brigades.Транспорт=Transports.ID");
            }
        }
    }
}
