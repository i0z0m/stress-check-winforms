﻿using StressCheck.ScreenTransition;
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
            Question question1 = new Question(1, "非常にたくさんの仕事をしなければならない", 0, true);
            Question question2 = new Question(2, "時間内に仕事が処理しきれない", 0, true);

            // SectionにQuestionを追加
            sectionA.Questions.Add(question1);
            sectionA.Questions.Add(question2);

            // sectionListに含まれるすべてのQuestionをquestionListに追加
            foreach (Section section in sectionList)
            {
                questionList.AddRange(section.Questions);
            }

            // currentQuestionを初期化
            if (currentQuestionIndex >= 0)
            {
                currentQuestion = questionList[currentQuestionIndex];

                //currentQuestion = sectionList[0].Questions[0];
            }

            LoadQuestion(sender, e);
        }

        private void LoadQuestion(object sender, EventArgs e)
        {
            // 問題文ラベルのTextプロパティに、現在表示中の問題の問題文を代入する
            labelSection.Text = currentSection.Name;
            labelID.Text = currentQuestion.ID.ToString();
            labelQuestion.Text = currentQuestion.Text;

            // 選択肢ボタンのテキストに、現在表示中の問題の選択肢を代入する
            buttonChoice1.Text = currentSection.Choices[0];
            buttonChoice2.Text = currentSection.Choices[1];
            buttonChoice3.Text = currentSection.Choices[2];
            buttonChoice4.Text = currentSection.Choices[3];
        }

        // 「次へ」ボタンがクリックされたときの処理
        private void buttonNext_Click(object sender, EventArgs e)
        {
            // 現在表示中の問題のインデックスを1つ増やす
            if (currentQuestionIndex < questionList.Count - 1)
            {
                currentQuestionIndex++;
                currentQuestion = questionList[currentQuestionIndex];
                LoadQuestion(sender, e);
            }
            else 
            {
                NavigationHelper.NavigateTo<UserControl4>(this);
            }
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

    }
}