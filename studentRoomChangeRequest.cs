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
    public partial class studentRoomChangeRequest : Form
    {
        string selectedText;
        Student st;
        public studentRoomChangeRequest(Object obj)
        {
            InitializeComponent();
            st = (Student)obj;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            //studentMainMenu returnmenu = new studentMainMenu();
            //returnmenu.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            AccommodationBooking studentBooking = new AccommodationBooking();
            Console.WriteLine("aa {0}", selectedText);

            studentBooking.changeRoomRequest(st.StudentID, selectedText);
            MessageBox.Show("You have submitted your request", "Request Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            //studentMainMenu mainmenu = new studentMainMenu();
            //mainmenu.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void block_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedText = block.Text;
        }

        private void studentRoomChangeRequest_Load(object sender, EventArgs e)
        {

        }
    }
}
