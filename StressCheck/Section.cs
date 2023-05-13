using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StressCheck
{
    public class Section
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Question> Questions { get; set; }
        public List<string> Choices { get; set; }
        public int TotalScore
        {
            get
            {
                int totalScore = 0;

                foreach (Question question in Questions)
                {
                    if (question.Reverse)
                    {
                        totalScore += (Choices.Count - question.Score + 1);
                    }
                    else
                    {
                        totalScore += question.Score;
                    }
                }

                return totalScore;
            }
        }

        public Section(string name, string description)
        {
            Name = name;
            Description = description;
            Questions = new List<Question>();
            Choices = new List<string>();
        }
    }
}