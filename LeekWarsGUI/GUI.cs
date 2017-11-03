using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using API_Results;

namespace LeekWarsGUI
{
    public partial class GUI : Form
    {
        public Login LoginFarmer;
        public GUI(Login _LoginFarmer)
        {
            InitializeComponent();
            LoginFarmer = _LoginFarmer;
        }

        private void GUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void déconnexionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
