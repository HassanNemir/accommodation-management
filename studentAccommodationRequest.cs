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
        public studentAccommodationRequest()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            startDate.CustomFormat = "MMMM dd yyyy";


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            studentMainMenu returnmenu = new studentMainMenu();
            returnmenu.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            studentBooking = new AccommodationBooking(studentID.Text, startDate.Value, endDate.Value, block.Text);
            // @TODO add a confirmation message on submission
            // @TODO add validations
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
