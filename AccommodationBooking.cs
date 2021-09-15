using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accommodation_management
{
    class AccommodationBooking
    {
        private string bookingID;
        private string type;
        private string wardenID;
        private string studentID;
        private DateTime bookingDate;
        private DateTime startDate;
        private DateTime endDate;
        private string status;
        private int duration;
        private string block;

        public AccommodationBooking (string studentID, DateTime startDate, DateTime endDate, string block)
        {
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
            Utilities utils = new Utilities();

            /**
             * Insert values in accommodationBooking table
             */
            string query = $"INSERT INTO AccommodationBooking (bookingDate, startDate, endDate, bookingID, studentID, type, duration, status, block) VALUES ('{this.bookingDate}', '{this.startDate}', '{this.endDate}', '{this.bookingID}', '{this.studentID}', '{ this.type}', { this.duration}, '{ this.status}', '{ this.block}'); ";
            utils.SqlQuery(query);
        }

        public void accommodationTerminationRequest (string studentID, DateTime terminationDate)
        {
            /**
             * validate data
             */
            /**
             * store termination request in accommodation info
             */
            this.type = "termination";
            this.studentID = studentID;
        }
    }
}
