using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ambulance
{
    public partial class Authorization : Form
    {
        DataBase database = new DataBase();
        public Authorization()
        {
            InitializeComponent();
        }

        private void Authorization_Load(object sender, EventArgs e)
        {
            PasswordTB.PasswordChar = '*';
            LoginTB.MaxLength = 50;
            PasswordTB.MaxLength = 50;
            HideBox.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var loginUser = LoginTB.Text;
            var passUser = PasswordTB.Text;;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select ID, Login, Password from Operators where Login = '{loginUser}' and Password = '{passUser}'"; // проверка логина и пароля
            string role = "Select Role from Operators where Login = N'" + LoginTB.Text + "' and Password = " + PasswordTB.Text + ";"; // проверка роли
            string op1 = "Select Lastname from Operators where Login = N'" + LoginTB.Text + "' and Password = " + PasswordTB.Text + ";"; //запись фамилии в string
            string op2 = "Select Firstname from Operators where Login = N'" + LoginTB.Text + "' and Password = " + PasswordTB.Text + ";"; //запись имени в string
            string op3 = "Select Secondname from Operators where Login = N'" + LoginTB.Text + "' and Password = " + PasswordTB.Text + ";"; //запись отчества в string
            string op4 = "Select ID from Operators where Login = N'" + LoginTB.Text + "' and Password = " + PasswordTB.Text + ";";
            database.openConnection();

            SqlCommand command = new SqlCommand(querystring, database.getConnection()); //передача команд
            SqlCommand command1 = new SqlCommand(role, database.getConnection());
            SqlCommand command2 = new SqlCommand(op1, database.getConnection());
            SqlCommand command3 = new SqlCommand(op2, database.getConnection());
            SqlCommand command4 = new SqlCommand(op3, database.getConnection());
            SqlCommand command5 = new SqlCommand(op4, database.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count==1) // если такая строчка есть в бд, выполняется sql данные переводятся в string
            {
                string opF = command2.ExecuteScalar().ToString();
                string opN = command3.ExecuteScalar().ToString();
                string opS = command4.ExecuteScalar().ToString();
                string opID1 = command5.ExecuteScalar().ToString();
                string opFull = opF +" "+ opN +" "+ opS;
                string role1 = command1.ExecuteScalar().ToString();
                
               
                if (role1.Trim() == "Admin")
                {
                    Form1 AdminPanel = new Form1();
                    AdminPanel.Show();
                    this.Hide();
                }
                else if (role1.Trim() == "Op")
                {
                    OperatorPanel OPpanel = new OperatorPanel();
                    OPpanel.opName = opFull;
                    OPpanel.opID = opID1.Trim();
                    OPpanel.Show();
                    this.Hide();
                   
                }
            }
            else
            {
                MessageBox.Show("Введены неверные данные");
            }
        }

        private void OpenBox_Click(object sender, EventArgs e)
        {
            PasswordTB.UseSystemPasswordChar = false;
            OpenBox.Visible = false;
            HideBox.Visible = true;
        }

        private void HideBox_Click(object sender, EventArgs e)
        {
            PasswordTB.UseSystemPasswordChar = true;
            HideBox.Visible = false;
            OpenBox.Visible = true;
        }

        private void ClearBox_Click(object sender, EventArgs e)
        {
            LoginTB.Text = "";
            PasswordTB.Text = "";
        }
    }
}
