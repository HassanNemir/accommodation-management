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
            string query = $"INSERT INTO AccommodationBooking (bookingID, studentID, wardenID, type, startDate, endDate, duration, status, block) VALUES ({this.bookingID}, {this.studentID}, {this.wardenID},  { this.type}, { this.startDate}, { this.endDate}, { this.duration}, { this.status}, { this.block}) ";
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
