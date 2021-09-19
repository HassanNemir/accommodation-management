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
        public wardenFeedback()
        {
            InitializeComponent();
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

            }

            foreach (Feedback fb in feedbacks)
            {
                studentIDList.Items.Add(fb.stID);
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
    }
}
