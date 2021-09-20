using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accommodation_management
{
    class Student
    {
        private string studentID;
        private string roomNumber;
        private string fullName;
        private string contactNumber;

        public Student(string studentID, string roomNumber, string fullName, string contactNumber)
        {
            this.studentID = studentID;
            this.roomNumber = roomNumber;
            this.fullName = fullName;
            this.contactNumber = contactNumber;
        }

        public string StudentID
        {
            get { return studentID; }
        }

        public string FullName
        {
            get { return fullName; }
        }

        public string RoomNumber
        {
            get { return roomNumber; }
        }
        public void terminateStudentAccommodation(string studentID)
        {
            this.studentID = studentID;
            Utilities utils = new Utilities();
            string query1 = $"UPDATE students SET roomNumber=Null WHERE studentID='{this.studentID}';";
            string query2 = $"UPDATE AccommodationInformation SET studentID=Null WHERE studentID='{this.studentID}';";

            utils.SqlQuery(query1 + query2);
        }
    }
}
