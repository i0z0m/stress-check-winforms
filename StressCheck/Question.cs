using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StressCheck
{
    public class Question
    {
        public int ID { get; set; }
        public string Text { get; set; }
        public int Score { get; set; }
        public bool Reverse { get; set; }

        public Question(int id, string text, int score, bool reverse)
        {
            ID = id;
            Text = text;
            Score = score;
            Reverse = reverse;
        }
    }
}

