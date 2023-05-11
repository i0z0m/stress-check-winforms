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
using static StressCheck.NavigationHelper;


namespace StressCheck
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            UserControl1 userControl1 = new UserControl1();
            MainPanel.Controls.Add(userControl1);
        }

        private Panel _mainPanel;

        public Panel mainPanel
        {
            get { return _mainPanel; }
            set { _mainPanel = value; }
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
