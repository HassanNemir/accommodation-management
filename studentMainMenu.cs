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
        Object oj;
        public studentMainMenu(Object obj)
        {
            InitializeComponent();
            oj = obj;
        }

        private void studentMainMenu_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            studentAccommodationRequest accommodationreq = new studentAccommodationRequest(oj);
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
            studentRoomChangeRequest accommodationchg = new studentRoomChangeRequest(oj);
            accommodationchg.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            studentTerminationRequest accommodationterminate = new studentTerminationRequest(oj);
            accommodationterminate.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            studentFeedback studentFeedback = new studentFeedback(oj);
            studentFeedback.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
