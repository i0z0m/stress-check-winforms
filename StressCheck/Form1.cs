using StressCheck.ScreenTransition;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace StressCheck
{
    public partial class mainForm : Form
    {
        private UserControl1 userControl1;

        public mainForm()
        {
            InitializeComponent();
        }


        private void mainForm_Load(object sender, EventArgs e)
        {
            userControl1 = new UserControl1();
            mainPanel.Controls.Add(userControl1);
        }



        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
