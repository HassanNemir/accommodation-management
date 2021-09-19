using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accommodation_management
{
    class Feedback
    {
        private string feedbackID;
        private string studentID;
        private string wardenID;
        private DateTime feedbackDate;
        private string subject;
        private string feedback;

        public Feedback(string studentID, string subject, string feedback)
        {
            this.studentID = studentID;
            this.subject = subject;
            this.feedback = feedback;
            this.feedbackDate = DateTime.Now;

            /**
            * compute feedbackID
            */
            string timestamp = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds().ToString();
            this.feedbackID = "f" + timestamp;

            /**
             * store in the DB
             */
            Utilities utils = new Utilities();
            string query = $"INSERT INTO Feedback (feedbackID, studentID, feedbackDate, subject, feedback) VALUES ('{this.feedbackID}', '{this.studentID}', '{this.feedbackDate}', '{this.subject}', '{this.feedback}'); ";
            utils.SqlQuery(query);
        }

    }
}
