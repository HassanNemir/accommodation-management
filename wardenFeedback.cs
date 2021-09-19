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
    public partial class wardenFeedback : Form
    {
        Feedback fb;
        List<Feedback> feedbacks = new List<Feedback>();
        string selectedStudentID;
        string selectedFeedbackID;
        Warden wr;
        public wardenFeedback(Object oj)
        {
            InitializeComponent();
            wr = (Warden)oj;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void wardenFeedback_Load(object sender, EventArgs e)
        {
            fb = new Feedback();
            SqlDataReader dr = fb.getFeedback();
            if (dr.HasRows)
            {

                string feedbackID = (string)dr["feedbackID"];
                string studentID = (string)dr["studentID"];
                string studentFullName = (string)dr["fullName"];
                string subject = (string)dr["subject"];
                string feedback = (string)dr["feedback"];
                string roomNumber = dr["roomNumber"] == DBNull.Value ? String.Empty : (string)dr["roomNumber"];


                Feedback fb = new Feedback(feedbackID, studentID, studentFullName, roomNumber, subject, feedback);
                feedbacks.Add(fb);
                fb = null;

                while (dr.Read())
                {
                    string feedbackID2 = (string)dr["feedbackID"];
                    string studentID2 = (string)dr["studentID"];
                    string studentFullName2 = (string)dr["fullName"];
                    string subject2 = (string)dr["subject"];
                    string feedback2 = (string)dr["feedback"];
                    string roomNumber2 = dr["roomNumber"] == DBNull.Value ? String.Empty : (string)dr["roomNumber"];


                    Feedback fb2 = new Feedback(feedbackID2, studentID2, studentFullName2, roomNumber2, subject2, feedback2);
                    feedbacks.Add(fb2);
                    fb2 = null;
                }

            }

            foreach (Feedback fb in feedbacks)
            {
                studentIDList.Items.Add($"Subject: {fb.Subject} | Student ID: {fb.stID}");
            }
        }

        private void studentIDList_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Feedback feedback in feedbacks)
            {
                if (studentIDList.Text == feedback.stID)
                {
                    selectedStudentID = feedback.stID;
                    studentName.Text = feedback.fullName;
                    subject.Text = feedback.Subject;
                    selectedFeedbackID = feedback.FeedbackID;
                    roomNumber.Text = feedback.RoomNumber;
                    feedbacktxt.Text = feedback.feedbackTxt;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Feedback feedback = new Feedback();
            feedback.updateFeedback(selectedFeedbackID, fbComment.Text, "ttestWr1");
        }

        private void studentIDList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
