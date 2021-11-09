using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using ServiceMtk_P1_20190140104;


namespace ServerConfigForm_P5_20190140104
{
    public partial class Form1 : Form
    {
        private ServiceHost Host;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnOn_Click(object sender, EventArgs e)
        {
            Host = new ServiceHost(typeof(Matematika));

            labelOnorOff.Text = "Server is ON";
            labelKet.Text = "Click OFF to SHUTDOWN the Server";
            Host.Open();
            btnOn.Enabled = false;
            btnOff.Enabled = true;
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            btnOn.Enabled = true;
            btnOff.Enabled = false;
            Host.Close();
            labelKet.Text = "Click ON to START the Server";
            labelOnorOff.Text = "Server is OFF";
        }
    }
}
