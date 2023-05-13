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
        private int currentQuestionIndexInSection = 0;
        private List<Question> questionList = new List<Question>();

        private void UserControl3_Load(object sender, EventArgs e)
        {
            loadQuestions(sender, e);
            displayQuestions(sender, e);
        }

        private void loadQuestions(object sender, EventArgs e)
        {
            Section sectionA = new Section("A", "あなたの仕事についてうかがいます。最もあてはまる選択ボタンを選んでください。")
            {
                Choices = { "そうだ", "まあそうだ", "ややちがう", "ちがう" },
                Questions =
                {
                    new Question(1, "非常にたくさんの仕事をしなければならない", 0, true),
                    new Question(2, "時間内に仕事が処理しきれない", 0, true),
                    new Question(3, "一生懸命働かなければならない", 0, true),
                    new Question(4, "かなり注意を集中する必要がある", 0, true),
                    new Question(5, "高度の知識や技術が必要なむずかしい仕事だ", 0, true),
                    new Question(6, "勤務時間中はいつも仕事のことを考えていなければならない", 0, true),
                    new Question(7, "からだを大変よく使う仕事だ", 0, true),
                    new Question(8, "自分のペースで仕事ができる", 0, false),
                    new Question(9, "自分で仕事の順番・やり方を決めることができる", 0, false),
                    new Question(10, "職場の仕事の方針に自分の意見を反映できる", 0, false),
                    new Question(11, "自分の技能や知識を仕事で使うことが少ない", 0, true),
                    new Question(12, "私の部署内で意見のくい違いがある", 0, true),
                    new Question(13, "私の部署と他の部署とはうまが合わない", 0, true),
                    new Question(14, "私の職場の雰囲気は友好的である", 0, false),
                    new Question(15, "私の職場の作業環境（騒音、照明、温度、換気など）はよくない", 0, true),
                    new Question(16, "仕事の内容は自分にあっている", 0, false),
                    new Question(17, "働きがいのある仕事だ",  0, false)
                }
            };

            Section sectionB = new Section("B", "最近 1 か月間のあなたの状態についてうかがいます。最もあてはまる選択ボタンを選んでください。")
            {
                Choices = { "ほとんどなかった", "ときどきあった", "しばしばあった", "ほとんどいつもあった" },
                Questions =
                {
                    new Question(1, "活気がわいてくる", 0, true)
                }
            };

            // sectionListにSectionを追加
            sectionList.Add(sectionA);
            sectionList.Add(sectionB);

            // currentSectionを初期化
            currentSection = sectionList[currentSectionIndex];

            // sectionListに含まれるすべてのQuestionをquestionListに追加
            foreach (Section section in sectionList)
            {
                questionList.AddRange(section.Questions);
            }

            // currentQuestionを初期化
            currentQuestion = questionList[currentQuestionIndexInSection];
        }

        private void displayQuestions(object sender, EventArgs e)
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
            currentQuestionIndexInSection++;

            if (currentQuestionIndexInSection >= currentSection.Questions.Count)
            {
                // 現在のセクションが終了した場合
                if (currentSectionIndex < sectionList.Count - 1)
                {
                    // 次のセクションがある場合
                    currentSectionIndex++;
                    currentSection = sectionList[currentSectionIndex];
                    currentQuestionIndexInSection = 0;

                    // 次のセクションの最初の問題に移る前に画面遷移する
//                    Console.WriteLine("currentSection before transition: " + currentSection.Name); // テスト
                    NavigationHelper.NavigateTo<UserControl2>(currentSection);
                }
                else
                {
                    // 全てのセクションが終了した場合
                    NavigationHelper.NavigateTo<UserControl4>();
                    return;
                }
            }
            // 次の問題を表示する
            currentQuestion = currentSection.Questions[currentQuestionIndexInSection];
            displayQuestions(sender, e);
        }

        private void buttonChoice1_Click(object sender, EventArgs e)
        {
            questionList[currentQuestionIndexInSection].Score = 1;
            buttonNext_Click(sender, e);
        }


        private void buttonChoice2_Click(object sender, EventArgs e)
        {
            questionList[currentQuestionIndexInSection].Score = 2;
            buttonNext_Click(sender, e);
        }

        private void buttonChoice3_Click(object sender, EventArgs e)
        {
            questionList[currentQuestionIndexInSection].Score = 3;
            buttonNext_Click(sender, e);
        }

        private void buttonChoice4_Click(object sender, EventArgs e)
        {
            questionList[currentQuestionIndexInSection].Score = 4;
            buttonNext_Click(sender, e);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            // 現在表示中の問題のインデックスを1つ減らす
            currentQuestionIndexInSection--;

            if (currentQuestionIndexInSection < 0)
            {
                // 現在のセクションの最初の問題を表示している場合
                currentSectionIndex--;

                if (currentSectionIndex >= 0)
                {
                    // 前のセクションがある場合
                    currentSection = sectionList[currentSectionIndex];
                    currentQuestionIndexInSection = currentSection.Questions.Count - 1;
                }
                else
                {
                    // 最初のセクションの最初の問題を表示している場合
                    NavigationHelper.NavigateBack();
                    return;
                }
            }

            // 問題を表示
            currentQuestion = currentSection.Questions[currentQuestionIndexInSection];
            displayQuestions(sender, e);
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
