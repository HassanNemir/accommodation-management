using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace accommodation_management
{
    public partial class Accommodation_Termination : Form
    {
        AccommodationBooking accBooking;
        List<AccommodationBooking> bookings = new List<AccommodationBooking>();
        Warden wr;
        Object obj;
        string selectedStudentID;
        string selectedBookingID;
        public Accommodation_Termination(Object oj)
        {
            InitializeComponent();
            obj = oj;
            wr = (Warden)oj;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            wardenMainMenu returnmenu = new wardenMainMenu(obj);
            returnmenu.ShowDialog();
        }

        private void Accommodation_Termination_Load(object sender, EventArgs e)
        {
            accBooking = new AccommodationBooking();
            SqlDataReader dr = accBooking.getTerminationRequests();
            if (dr.HasRows)
            {

                    string bookingID = (string)dr["bookingID"];
                    string studentID = (string)dr["studentID"];
                    string studentFullName = (string)dr["fullName"];
                    string roomNumber = dr["roomNumber"] == DBNull.Value ? String.Empty : (string)dr["roomNumber"];

                    AccommodationBooking b = new AccommodationBooking(bookingID, studentID, studentFullName, roomNumber);
                    bookings.Add(b);
                    b = null;
                
            }

            foreach (AccommodationBooking booking in bookings)
            {
                studentIDList.Items.Add(booking.stID);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (AccommodationBooking booking in bookings)
            {
                if (studentIDList.Text == booking.stID)
                {
                    selectedStudentID = booking.stID;
                    selectedBookingID = booking.BookingID;
                    studentName.Text = booking.fullName;
                    roomNumber.Text = booking.roomNumber;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AccommodationBooking booking = new AccommodationBooking();
            booking.terminateStudentAccommodation(selectedBookingID, "ttestWr1", selectedStudentID, roomNumber.Text);
        }
    }
}
