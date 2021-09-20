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
    public partial class studentAccommodationRequest : Form
    {
        AccommodationBooking studentBooking;
        Student st;
        public studentAccommodationRequest(Object obj)
        {
            InitializeComponent();
            st = (Student)obj;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            startDate.CustomFormat = "MMMM dd yyyy";
            // Set endDate to 17 weeks after the start date by default
            endDate.Value = startDate.Value.AddDays(119);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            // studentMainMenu returnmenu = new studentMainMenu();
            //return menu.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(block.Text))
            {
                MessageBox.Show("Please select an accommodation block.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                try
                {
                    studentBooking = new AccommodationBooking(st.StudentID, startDate.Value, endDate.Value, block.Text);
                    MessageBox.Show("You have submitted your request", "Request Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    studentMainMenu mainmenu = new studentMainMenu(st);
                    mainmenu.ShowDialog();
                } 
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void block_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void studentAccommodationRequest_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
