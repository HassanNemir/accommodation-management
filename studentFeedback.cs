﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace accommodation_management
{
    public partial class studentFeedback : Form
    {
        Feedback stFeedback;
        Student st;
        public studentFeedback(Object obj)
        {
            InitializeComponent();
            st = (Student)obj;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            //studentMainMenu returnmenu = new studentMainMenu();
            //returnmenu.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
         
        private void button1_Click(object sender, EventArgs e)
        {
            stFeedback = new Feedback(st.StudentID, subject.Text, feedback.Text);
        }
    }
}
