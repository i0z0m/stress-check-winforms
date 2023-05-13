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

        private Section currentSection;

        private void UserControl2_Load(object sender, EventArgs e)
        {
            if (currentSection == null) // 初回表示時のみcurrentSectionを初期化
            {
                currentSection = new Section("A", "あなたの仕事についてうかがいます。最もあてはまる選択ボタンを選んでください。");
            }
//            Console.WriteLine("currentSection in UserControl2_Load: " + currentSection.Name); // テスト
            labelSectionN.Text = currentSection.Name;
            labelSectionD.Text = currentSection.Description;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            NavigationHelper.NavigateTo<UserControl3>();
        }

        private void labelSectionD_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NavigationHelper.NavigateTo<UserControl1>();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NavigationHelper.NavigateBack();
        }
    }
}
