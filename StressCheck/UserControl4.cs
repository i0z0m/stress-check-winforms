using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace StressCheck
{
    public partial class UserControl4 : UserControl
    {
        public UserControl4()
        {
            InitializeComponent();
        }

        private void UserContro4_Loaded(object sender, EventArgs e)
        {
            DisplayResults();
        }

        private Employee employee = new Employee();

        private void DisplayResults()
        {
            Section sectionB = new Section("B", "最近 1 か月間のあなたの状態についてうかがいます。最もあてはまる選択ボタンを選んでください。");
            // ここで、totalScoresを使って結果を表示する処理を実装する
            if (sectionB.TotalScore >= 77)
            {
                // 高ストレス者と判定する処理を記述
            employee.StressLevel = StressLevel.HIGH;
            }
        }
    }
}
