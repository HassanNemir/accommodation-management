using System;
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
    public partial class Accommodation_Assignment_and_Change : Form
    {
        public Accommodation_Assignment_and_Change()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            wardenMainMenu returnmenu = new wardenMainMenu();
            returnmenu.ShowDialog();
        }

        private void studentIDList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Accommodation_Assignment_and_Change_Load(object sender, EventArgs e)
        {
            string[] test = new string[2];
            test[0] = "hello";
            test[1] = "hey";
            studentIDList.Items.AddRange(test);
        }
    }
}
