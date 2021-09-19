using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace accommodation_management
{
    class AccommodationBooking
    {
        private string bookingID;
        private string type;
        private string wardenID;
        private string studentID;
        private string studentFullName;
        private string studentRoomNumber;
        private DateTime bookingDate;
        private DateTime startDate;
        private DateTime endDate;
        private string status;
        private int duration;
        private string block;
        private string terminationReason;
        private DateTime terminationDate;

        public string BookingID
        {
            get { return bookingID; }
        }
        public string stID
        {
            get { return studentID; }
        }

        public string roomNumber
        {
            get { return studentRoomNumber; }
        }

        public string Block
        {
            get { return block; }
        }

        public string fullName
        {
            get { return studentFullName; }
        }
        public AccommodationBooking()
        {

        }

        public AccommodationBooking(string bookingID, string studentID, string studentFullName, string studentRoomNumber)
        {
            this.bookingID = bookingID;
            this.studentID = studentID;
            this.studentFullName = studentFullName;
            this.studentRoomNumber = studentRoomNumber;
        }

        public AccommodationBooking (string studentID, DateTime startDate, DateTime endDate, string block)
        {
            Utilities utils = new Utilities();
            SqlDataReader recs = utils.SqlQuery($"SELECT * FROM AccommodationBooking WHERE studentID='{studentID}' AND status='In progress'");
            if (recs.HasRows)
            {
                throw new ArgumentException("Student already has a request in progress");
            }
            /**
             * validations
             */

            /**
             * set values
             */
            this.studentID = studentID;
            this.type = "booking";
            this.startDate = startDate;
            this.endDate = endDate;
            this.block = block;
            this.status = "In progress";
            this.wardenID = "";
            this.bookingDate = DateTime.Now;
            /**
             * compute bookingID
             */
            string timestamp = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds().ToString();
            this.bookingID = "b" + timestamp;
            /**
             * compute duration in days
             */
            this.duration = (endDate - startDate).Days;

            /**
             * Insert values in AccommodationBooking table
             */
            string query = $"INSERT INTO AccommodationBooking (bookingDate, startDate, endDate, bookingID, studentID, type, duration, status, block) VALUES ('{this.bookingDate}', '{this.startDate}', '{this.endDate}', '{this.bookingID}', (SELECT studentID FROM students WHERE studentID = '{this.studentID}'), '{ this.type}', { this.duration}, '{ this.status}', '{ this.block}'); ";
            utils.SqlQuery(query);
        }

        public void accommodationTerminationRequest (string studentID, DateTime terminationDate, string terminationReason)
        {
            Utilities utils = new Utilities();


            /**
             * validate data
             */
            /**
             * store termination request in accommodation info
             */
            this.type = "termination";
            this.terminationReason = terminationReason;
            this.terminationDate = terminationDate;
            this.studentID = studentID;
            string query = $"INSERT INTO AccommodationBooking (bookingDate, terminationDate, terminationReason, bookingID, studentID, type, status) VALUES ('{this.bookingDate}', '{this.terminationDate}', '{this.terminationReason}', '{this.bookingID}', (SELECT studentID FROM students WHERE studentID = '{this.studentID}'), '{ this.type}', '{ this.status}'); ";
            utils.SqlQuery(query);
        }

        public void changeRoomRequest (string studentID, string block)
        {
            Utilities utils = new Utilities();


            /**
             * validate data
             */
            /**
             * store termination request in accommodation info
             */
            this.type = "change request";
            this.studentID = studentID;
            this.block = block;
            this.bookingDate = DateTime.Now;
            string timestamp = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds().ToString();
            this.bookingID = "b" + timestamp;
            this.status = "In progress";
            string query = $"INSERT INTO AccommodationBooking (bookingDate, block, bookingID, studentID, type, status) VALUES ('{this.bookingDate}', '{this.block}', '{this.bookingID}', (SELECT studentID FROM students WHERE studentID = '{this.studentID}'), '{ this.type}', '{ this.status}'); ";
            utils.SqlQuery(query);
        }

        public void updateStudentRoomNumber (string bookingID, string wardenID, string studentID, string roomNumber)
        {
            Utilities utils = new Utilities();
            string query1 = $"UPDATE students SET roomNumber=(SELECT roomNumber FROM AccommodationInformation WHERE roomNumber='{roomNumber}') WHERE studentID='{studentID}';";
            string query2 = $"UPDATE AccommodationBooking SET status='completed', wardenID=(SELECT wardenID FROM warden WHERE wardenID='{wardenID}') WHERE bookingID='{bookingID}';";
            string query3 = $"UPDATE AccommodationInformation SET studentID=(SELECT studentID FROM students WHERE studentID='{studentID}') WHERE roomNumber='{roomNumber}';";
            utils.SqlQuery(query1 + query2+ query3);
        }

        /**
         * Get all new bookings and change room requests
         */
        public SqlDataReader getBookingAndChangeRoomRequests ()
        {
            Utilities utils = new Utilities();
            string query = $"SELECT AccommodationBooking.bookingID, AccommodationBooking.studentID, students.fullName, students.roomNumber FROM AccommodationBooking JOIN students ON AccommodationBooking.studentID = students.studentID WHERE AccommodationBooking.status='In progress' AND (AccommodationBooking.type = 'booking' OR AccommodationBooking.type = 'change request'); ";
            return utils.SqlQuery(query);
        }
    }
}
