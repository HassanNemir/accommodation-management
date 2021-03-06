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
    public partial class studentTerminationRequest : Form
    {
        Student st;
        public studentTerminationRequest(Object obj)
        {
            InitializeComponent();
            st = (Student)obj;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
           studentMainMenu returnmenu = new studentMainMenu(st);
           returnmenu.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(terminationreason.Text))
            {
                MessageBox.Show("Please select a termination reason.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                AccommodationBooking studentBooking = new AccommodationBooking();
                studentBooking.accommodationTerminationRequest(st.StudentID, TerminationDate.Value, terminationreason.Text);
                MessageBox.Show("You have submitted your request", "Request Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                studentMainMenu mainmenu = new studentMainMenu(st);
                mainmenu.ShowDialog();
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void studentTerminationRequest_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
