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
        public wardenMainMenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Accommodation_Termination Terminate = new Accommodation_Termination();
            Terminate.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Accommodation_Assignment_and_Change Assign = new Accommodation_Assignment_and_Change();
            Assign.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login returnwarden = new Login();
            returnwarden.ShowDialog();
        }
    }
}
