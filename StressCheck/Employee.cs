using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StressCheck
{
    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public int StressLevel { get; set; }
    }

    // 列挙型のGenderクラスを定義
    public enum Gender
    {
        MALE,
        FEMALE
    }
}
