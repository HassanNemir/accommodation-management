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
    public partial class studentMainMenu : Form
    {
        public studentMainMenu()
        {
            InitializeComponent();
        }

        private void studentMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 accommodationreq = new Form1();
            accommodationreq.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login returnstudent = new Login();
            returnstudent.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 accommodationchg = new Form2();
            accommodationchg.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 accommodationterminate = new Form4();
            accommodationterminate.ShowDialog();
        }
    }
}
