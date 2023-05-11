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
using static StressCheck.Section;
using static StressCheck.Question;
using static System.Collections.Specialized.BitVector32;

namespace StressCheck
{
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {
            Section section = new Section("A", "あなたの仕事についてうかがいます。最もあてはまる選択ボタンを選んでください。");
            labelSectionN.Text = section.Name;
            labelSectionD.Text = section.Description;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            NavigationHelper.NavigateTo<UserControl3>();
        }

        private void labelSectionD_Click(object sender, EventArgs e)
        {

        }
    }
}
