using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thw_3._1
{
    class Teacher: Student
    {
        public string Subject { get; private set; }

        public Teacher():base()
        {
            Subject = "Math";
        }

        public Teacher(string name, int age, string gender, int weight, int year, string subject) :base(name, age, gender, weight,year)
        {
            Subject = subject;
        }

        public void SetSubject(string subject)
        {
            Subject = subject;
        }
    }
}
