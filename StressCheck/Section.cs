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

        public Section(string name, string description)
        {
            Name = name;
            Description = description;
            Questions = new List<Question>();
            Choices = new List<string>();
        }
    }
}