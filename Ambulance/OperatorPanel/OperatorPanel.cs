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
    public partial class OperatorPanel : Form
    {
        public OperatorPanel()
        {
            InitializeComponent();
        }
        public string opName;
        public string opID;

        private void OperatorPanel_Load(object sender, EventArgs e)
        {
            OperatorLabel.Text = opName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoctorCall dc = new DoctorCall();
            dc.operID = opID;
            dc.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActiveCall ac = new ActiveCall();
            ac.Show();
        }
    }
}
