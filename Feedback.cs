using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

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
        private string roomNumber;
        private string studentFullName;
        private string status;

        public string stID
        {
            get { return studentID; }
        }

        public string fullName
        {
            get { return studentFullName; }
        }

        public string Subject
        {
            get { return subject; }
        }

        public string RoomNumber
        {
            get { return roomNumber; }
        }
        public string feedbackTxt
        {
            get { return feedback; }
        }

        public string FeedbackID
        {
            get { return feedbackID; }
        }


        public Feedback()
        {

        }
        public Feedback (string feedbackID, string studentID, string studentFullName, string roomNumber, string subject, string feedback)
        {
            this.feedbackID = feedbackID;
            this.studentID = studentID;
            this.studentFullName = studentFullName;
            this.roomNumber = roomNumber;
            this.subject = subject;
            this.feedback = feedback;
        }
        public Feedback(string studentID, string subject, string feedback)
        {
            this.studentID = studentID;
            this.subject = subject;
            this.feedback = feedback;
            this.feedbackDate = DateTime.Now;
            this.status = "In progress";

            /**
            * compute feedbackID
            */
            string timestamp = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds().ToString();
            this.feedbackID = "f" + timestamp;

            /**
             * store in the DB
             */
            Utilities utils = new Utilities();
            string query = $"INSERT INTO Feedback (feedbackID, studentID, feedbackDate, subject, feedback, status) VALUES ('{this.feedbackID}', '{this.studentID}', '{this.feedbackDate}', '{this.subject}', '{this.feedback}', '{this.status}'); ";
            utils.SqlQuery(query);
        }

        public SqlDataReader getFeedback()
        {
            Utilities utils = new Utilities();
            string query = $"SELECT Feedback.feedbackID, Feedback.studentID, Feedback.subject, Feedback.feedback, students.fullName, students.roomNumber FROM Feedback JOIN students ON Feedback.studentID = students.studentID WHERE Feedback.status='In progress'; ";
            return utils.SqlQuery(query);
        }

        public void updateFeedback(string feedbackID, string wardenComment, string wardenID)
        {
            Utilities utils = new Utilities();
            string query = $"UPDATE Feedback SET status='completed', feedbackComment='{wardenComment}', wardenID=(SELECT wardenID FROM warden WHERE wardenID='{wardenID}') WHERE feedbackID='{feedbackID}';";
            utils.SqlQuery(query);
        }

    }
}
