using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace accommodation_management
{
    public partial class wardenMainMenu : Form
    {
        Object oj;
        Warden wr;
        public wardenMainMenu(Object obj)
        {
            InitializeComponent();
            oj = obj;
            wr = (Warden)oj;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Accommodation_Termination Terminate = new Accommodation_Termination(wr);
            Terminate.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Accommodation_Assignment_and_Change Assign = new Accommodation_Assignment_and_Change(wr);
            Assign.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login returnwarden = new Login();
            returnwarden.ShowDialog();
        }

        private void wardenMainMenu_Load(object sender, EventArgs e)
        {
            wardenName.Text = wr.WardenName;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            wardenFeedback fbackmenu = new wardenFeedback(wr);
            fbackmenu.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            accommodationReport rep = new accommodationReport();
            rep.ShowDialog();
        }
    }
}
