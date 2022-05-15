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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }
        string report = "за всё время";
        string oper;
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
        private void Reports_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ambulanceDataSet.Doctor_call". При необходимости она может быть перемещена или удалена.
            this.doctor_callTableAdapter.Fill(this.ambulanceDataSet.Doctor_call);
            RepBox.Text = RepBox.Items[0].ToString();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            ////try
            ////{
            //   // this.doctor_callTableAdapter.FillBy(this.ambulanceDataSet.Doctor_call);
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DGVPrinterHelper.DGVPrinter printer = new DGVPrinterHelper.DGVPrinter();
            printer.SubTitle = "Отчёт по вызовам  " +report+ " " +oper+ "";
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = string.Format("Дата печати: {0}", DateTime.Now.ToString());
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dataGridView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (OpTB.Text.Length > 0)
                {
                    string op = OpTB.Text;
                    oper = "выполненных оператором " + op+"";
                    if (RepBox.Text == "За последние 30 дней")
                    {
                        report = "за 30 дней";
                        Connect("SELECT Фамилия, Имя, Отчество, Возраст, Адрес, Телефон, Дата_вызова, Время, Бригада, Повод_вызова, Оператор FROM dbo.Doctor_call WHERE Дата_вызова>=GETDATE()-30 AND Оператор LIKE '" + op + "'");
                    }
                    else if (RepBox.Text == "За последние 90 дней")
                    {
                        report = "за 90 дней";
                        Connect("SELECT Фамилия, Имя, Отчество, Возраст, Адрес, Телефон, Дата_вызова, Время, Бригада, Повод_вызова, Оператор FROM dbo.Doctor_call WHERE Дата_вызова>=GETDATE()-90 AND Оператор LIKE '" + op + "'");
                    }
                    else if (RepBox.Text == "За всё время")
                    {
                        report = "за всё время";
                        Connect("SELECT Фамилия, Имя, Отчество, Возраст, Адрес, Телефон, Дата_вызова, Время, Бригада, Повод_вызова, Оператор FROM dbo.Doctor_call WHERE Оператор LIKE '" + op + "'");
                    }
                }
                else
                {
                    if (RepBox.Text == "За последние 30 дней")
                    {
                        Connect("SELECT Фамилия, Имя, Отчество, Возраст, Адрес, Телефон, Дата_вызова, Время, Бригада, Повод_вызова, Оператор FROM dbo.Doctor_call WHERE Дата_вызова>=GETDATE()-30");
                    }
                    else if (RepBox.Text == "За последние 90 дней")
                    {
                        Connect("SELECT Фамилия, Имя, Отчество, Возраст, Адрес, Телефон, Дата_вызова, Время, Бригада, Повод_вызова, Оператор FROM dbo.Doctor_call WHERE Дата_вызова>=GETDATE()-90");
                    }
                    else
                    {
                        Connect("SELECT Фамилия, Имя, Отчество, Возраст, Адрес, Телефон, Дата_вызова, Время, Бригада, Повод_вызова, Оператор FROM dbo.Doctor_call");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Проверьте целостность данных");
            }
        }
    }
}
