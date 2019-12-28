using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_5
{
    class Program
    {
        class Program_1
        {
            struct Student
            {
                public int age;
                public string name;
            }
            enum DayOfTime : long
            {
                Moring = 9,
                Noon = 9,
                Afernoon
            }

            static void Main(string[] args)
            {
                Student s1;
                s1.age = 18;
                Student[] ss = new Student[100];
                DayOfTime d1;
                d1 = DayOfTime.Noon;

            }
        }
    }
}
