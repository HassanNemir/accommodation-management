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
    public partial class Login : Form
    {
        List<Student> students = new List<Student>();
        List<Warden> wardens = new List<Warden>();

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Utilities utils = new Utilities();

            /**
             * Insert values in accommodationBooking table
             */
            string query = $"Select * from students where email='{textBox1.Text}' AND password='{textBox2.Text}'";
            utils.SqlQuery(query);
            var email = textBox1.Text;

            // this should have the data from the db
            SqlDataReader dr = utils.SqlQuery(query);
            // dr has the data that we should use to login the user
            Student st;
            Warden wd;
            if (dr.HasRows)
            {
                string studentID = (string)dr["studentID"];
                string fullName = (string)dr["fullName"];
                string roomNumber = (string)dr["roomNumber"];
                string contactNumber = (string)dr["contactNumber"];
                st = new Student(studentID, roomNumber, fullName, contactNumber);
                students.Insert(0, st);
                
                MessageBox.Show("You have logged in successfully", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                studentMainMenu mainmenu = new studentMainMenu(students[0]);
                mainmenu.ShowDialog();
            }
            else
            {
                string Wquery = $"Select * from warden where email='{textBox1.Text}' AND password='{textBox2.Text}'";
                utils.SqlQuery(Wquery);
                SqlDataReader Wdr = utils.SqlQuery(Wquery);
                if (Wdr.HasRows)
                {
                    string wardenID = (string)Wdr["wardenID"];
                    string wardenName = (string)Wdr["wardenName"];
                    string wrEmail = (string)Wdr["email"];
                    string contactNumber = (string)Wdr["contactNumber"];
                    wd = new Warden(wardenID, wardenName, wrEmail, contactNumber);
                    wardens.Insert(0, wd);

                    MessageBox.Show("You have logged in successfully", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    wardenMainMenu Wmainmenu = new wardenMainMenu(wardens[0]);
                    Wmainmenu.ShowDialog();
                }
                else
                {
                 MessageBox.Show("Incorrect email or password. Please retry.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Usernameclick(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel4.BackColor = SystemColors.Control;
            textBox2.BackColor = SystemColors.Control;
        }

        private void Passwordclick(object sender, EventArgs e)
        {
            textBox1.BackColor = SystemColors.Control;
            panel3.BackColor = SystemColors.Control;
            panel4.BackColor = Color.White;
            textBox2.BackColor = Color.White;
        }

        private void Passwordreview(object sender, MouseEventArgs e)
        {
            textBox2.UseSystemPasswordChar = false;
        }

        private void Passwordconceal(object sender, MouseEventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }

        private void taboutuser(object sender, EventArgs e)
        {
            textBox1.BackColor = SystemColors.Control;
            panel3.BackColor = SystemColors.Control;
            panel4.BackColor = Color.White;
            textBox2.BackColor = Color.White;
        }

        private void taboutpass(object sender, EventArgs e)
        {
            textBox1.BackColor = SystemColors.Control;
            panel3.BackColor = SystemColors.Control;
            panel4.BackColor = SystemColors.Control;
            textBox2.BackColor = SystemColors.Control;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
