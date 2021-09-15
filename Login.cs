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
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectString;
            string sqlQuery;
            // change "AttachDbFilename" to the path of the .mdf file on your computer
            connectString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\hasan\OneDrive\Documents\accommodation-management\acm.mdf; Integrated Security = True";
            SqlCommand cmd = new SqlCommand();
            SqlConnection conn = new SqlConnection(connectString);
            conn.Open();
            var email = textBox1.Text;
            // here we build the query for looking for a student or warden
            sqlQuery = $"Select * from students where email='{textBox1.Text}' AND password='{textBox2.Text}'";
            cmd = new SqlCommand(sqlQuery, conn);
            SqlDataReader dr;
            // this should have the data from the db
            dr = cmd.ExecuteReader();

            // dr has the data that we should use to login the user


            // closing the connection
            dr.Close();

            conn.Close();

            if (email == "warden@accommodation.com")
            {
                this.Hide();
                wardenMainMenu mainmenu = new wardenMainMenu();
                mainmenu.ShowDialog();
            } else
            {
                this.Hide();
                studentMainMenu mainmenu = new studentMainMenu();
                mainmenu.ShowDialog();
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
    }
}
