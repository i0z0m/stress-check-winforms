using static StressCheck.NavigationHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StressCheck
{
    public partial class UserControl3 : UserControl
    {
        public UserControl3()
        {
            InitializeComponent();
        }

        private Section currentSection;
        private int currentSectionIndex = 0;
        private List<Section> sectionList = new List<Section>();

        private Question currentQuestion;
        private int currentQuestionIndex = 0;
        private List<Question> questionList = new List<Question>();

        private void UserControl3_Load(object sender, EventArgs e)
        {
            // Sectionを作成
            Section sectionA = new Section("A", "あなたの仕事についてうかがいます。最もあてはまる選択ボタンを選んでください。");
            Section sectionB = new Section("B", "最近 1 か月間のあなたの状態についてうかがいます。最もあてはまる選択ボタンを選んでください。");

            // Sectionの選択肢を設定
            sectionA.Choices = new List<string> { "そうだ", "まあそうだ", "ややちがう", "ちがう" };
            sectionB.Choices = new List<string> { "ほとんどなかった", "ときどきあった", "しばしばあった", "ほとんどいつもあった" };

            // sectionListにSectionを追加
            sectionList.Add(sectionA);
            sectionList.Add(sectionB);

            // currentSectionを初期化
            currentSection = sectionList[currentSectionIndex];

            // Questionを作成
            Question sectionA_question1 = new Question(1, "非常にたくさんの仕事をしなければならない", 0, true);
            Question sectionA_question2 = new Question(2, "時間内に仕事が処理しきれない", 0, true);
            Question sectionB_question1 = new Question(1, "活気がわいてくる", 0, true);

            // SectionにQuestionを追加
            sectionA.Questions.Add(sectionA_question1);
            sectionA.Questions.Add(sectionA_question2);
            sectionB.Questions.Add(sectionB_question1);

            // sectionListに含まれるすべてのQuestionをquestionListに追加
            foreach (Section section in sectionList)
            {
                questionList.AddRange(section.Questions);
            }

            // currentQuestionを初期化
            currentQuestion = questionList[currentQuestionIndex];

            LoadQuestion(sender, e);
        }

        private void LoadQuestion(object sender, EventArgs e)
        {
            // 問題文ラベルのTextプロパティに、現在表示中の問題の問題文を代入する
            labelSection.Text = currentSection.Name;
            labelID.Text = currentQuestion.ID.ToString();
            labelCount.Text = currentSection.Questions.Count.ToString();
            labelQuestion.Text = currentQuestion.Text;

            // 選択肢ボタンのテキストに、現在表示中の問題の選択肢を代入する
            buttonChoice1.Text = currentSection.Choices[0];
            buttonChoice2.Text = currentSection.Choices[1];
            buttonChoice3.Text = currentSection.Choices[2];
            buttonChoice4.Text = currentSection.Choices[3];
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            // 現在表示中の問題のインデックスを1つ増やす
            currentQuestionIndex++;

            if (currentQuestionIndex >= currentSection.Questions.Count)
            {
                // 現在のセクションが終了した場合
                if (currentSectionIndex < sectionList.Count - 1)
                {
                    // 次のセクションがある場合
                    currentSectionIndex++;
                    currentSection = sectionList[currentSectionIndex];
                    currentQuestionIndex = 0;

                    // 次のセクションの最初の問題に移る前に画面遷移する
//                    Console.WriteLine("currentSection before transition: " + currentSection.Name); // テスト
//                    NavigationHelper.NavigateTo<UserControl2>(currentSection);
                }
                else
                {
                    // 全てのセクションが終了した場合
                    NavigationHelper.NavigateTo<UserControl4>();
                    return;
                }
            }
            // 次の問題を表示する
            currentQuestion = currentSection.Questions[currentQuestionIndex];
            LoadQuestion(sender, e);
        }

        private void buttonChoice1_Click(object sender, EventArgs e)
        {
            questionList[currentQuestionIndex].Score = 1;
            buttonNext_Click(sender, e);
        }


        private void buttonChoice2_Click(object sender, EventArgs e)
        {
            questionList[currentQuestionIndex].Score = 2;
            buttonNext_Click(sender, e);
        }

        private void buttonChoice3_Click(object sender, EventArgs e)
        {
            questionList[currentQuestionIndex].Score = 3;
            buttonNext_Click(sender, e);
        }

        private void buttonChoice4_Click(object sender, EventArgs e)
        {
            questionList[currentQuestionIndex].Score = 4;
            buttonNext_Click(sender, e);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            // 現在表示中の問題のインデックスを1つ減らす
            currentQuestionIndex--;

            if (currentQuestionIndex < 0)
            {
                // 現在のセクションの最初の問題を表示している場合
                currentSectionIndex--;

                if (currentSectionIndex >= 0)
                {
                    // 前のセクションがある場合
                    currentSection = sectionList[currentSectionIndex];
                    currentQuestionIndex = currentSection.Questions.Count - 1;
                }
                else
                {
                    // 最初のセクションの最初の問題を表示している場合
                    NavigationHelper.NavigateBack();
                    return;
                }
            }

            // 問題を表示
            currentQuestion = currentSection.Questions[currentQuestionIndex];
            LoadQuestion(sender, e);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            NavigationHelper.NavigateTo<UserControl1>();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buttonBack_Click(sender, e);
        }
    }
}
