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
    public partial class Accommodation_Termination : Form
    {
        public Accommodation_Termination()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            wardenMainMenu returnmenu = new wardenMainMenu();
            returnmenu.ShowDialog();
        }
    }
}
