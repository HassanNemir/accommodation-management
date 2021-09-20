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
    public partial class Accommodation_Assignment_and_Change : Form
    {
        AccommodationBooking accBooking;
        List<AccommodationBooking> bookings = new List<AccommodationBooking>();
        Warden wr;
        Object obj;
        string selectedStudentID;
        string selectedBookingID;
        public Accommodation_Assignment_and_Change(Object oj)
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

        private void studentIDList_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (AccommodationBooking booking in bookings)
            {
                if(studentIDList.Text == booking.stID)
                {
                    selectedStudentID = booking.stID;
                    selectedBookingID = booking.BookingID;
                    studentName.Text = booking.fullName;
                    prevRoomNumber.Text = booking.roomNumber;
                    requestedBlock.Text = booking.Block;
                }
            }
        }

        private void Accommodation_Assignment_and_Change_Load(object sender, EventArgs e)
        {
            accBooking = new AccommodationBooking();
            SqlDataReader dr = accBooking.getBookingAndChangeRoomRequests();
            if (dr.HasRows)
            {
                
                    string bookingID = (string)dr["bookingID"];
                    string studentID = (string)dr["studentID"];
                    string studentFullName = (string)dr["fullName"];
                    string roomNumber = dr["roomNumber"] == DBNull.Value ? String.Empty : (string)dr["roomNumber"] ;
                   

                    AccommodationBooking b = new AccommodationBooking(bookingID, studentID, studentFullName, roomNumber);
                    bookings.Add(b);
                    b = null;

                while(dr.Read())
                {
                    string bookingID2 = (string)dr["bookingID"];
                    string studentID2 = (string)dr["studentID"];
                    string studentFullName2 = (string)dr["fullName"];
                    string roomNumber2 = dr["roomNumber"] == DBNull.Value ? String.Empty : (string)dr["roomNumber"];


                    AccommodationBooking b2 = new AccommodationBooking(bookingID2, studentID2, studentFullName2, roomNumber2);
                    bookings.Add(b2);
                    b2 = null;
                }
                
            }

            foreach(AccommodationBooking booking in bookings)
            {
                studentIDList.Items.Add(booking.stID);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //validate that values are not empty
            if(String.IsNullOrEmpty(roomNumber.Text) || String.IsNullOrEmpty(selectedStudentID))
            {
                MessageBox.Show("Selected student and room number can not be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                // It's validated in the class method that if room number is invalid
                // or assigned to another student the warden will get an error.
                try
                {
                    AccommodationBooking booking = new AccommodationBooking();
                    booking.updateStudentRoomNumber(selectedBookingID, wr.WardenID, selectedStudentID, roomNumber.Text);
                } catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
