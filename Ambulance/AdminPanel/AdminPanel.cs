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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        AdminPanel.Brigades brigades;
        AdminPanel.Operators operators;
        AdminPanel.Orderlies orderlies;
        AdminPanel.Paramedic paramedic;
        AdminPanel.Transport transport;
        Doctors doctors;
        Reports rep; 
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DoctorsBtn_Click(object sender, EventArgs e)
        {
            doctors = new Doctors();
            doctors.Show();
        }

        private void ParamedicBtn_Click(object sender, EventArgs e)
        {
            paramedic = new AdminPanel.Paramedic();
            paramedic.Show();
        }

        private void OrderliesBtn_Click(object sender, EventArgs e)
        {
            orderlies = new AdminPanel.Orderlies();
            orderlies.Show();
        }

        private void TransportsBtn_Click(object sender, EventArgs e)
        {
            transport = new AdminPanel.Transport();
            transport.Show();
        }

       

        private void BrigadesBtn_Click(object sender, EventArgs e)
        {
            brigades = new AdminPanel.Brigades();
            brigades.Show();
        }

        private void ReportesBtn_Click(object sender, EventArgs e)
        {
            rep = new Reports();
            rep.Show();
        }

        private void OperatorsBtn_Click(object sender, EventArgs e)
        {
            operators = new AdminPanel.Operators();
            operators.Show();
        }
    }
}
