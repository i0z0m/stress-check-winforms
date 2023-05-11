using static StressCheck.Employee;
using static StressCheck.NavigationHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace StressCheck
{
    public partial class UserControl1 : UserControl
    {
//        private readonly NavigationHelper navigationHelper;
        public UserControl1()
        {
            InitializeComponent(); 
        }

        private Employee employee = new Employee();

        private void buttonMale_Click(object sender, EventArgs e)
        {
            employee.Gender = Gender.MALE;
            NavigationHelper.NavigateTo<UserControl2>(this);
        }

        private void buttonFemale_Click(object sender, EventArgs e)
        {
            employee.Gender = Gender.FEMALE;
            NavigationHelper.NavigateTo<UserControl2>(this);
        }
    }
}