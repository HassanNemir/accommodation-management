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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            dateTimePicker1.CustomFormat = "MMMM dd yyyy";


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            studentMainMenu returnmenu = new studentMainMenu();
            returnmenu.ShowDialog();
        }
    }
}
