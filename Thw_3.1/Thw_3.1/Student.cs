using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thw_3._1
{
    class Student : Man
    {
        public int AducationYear { get; private set; }

        public Student():base()
        {
            AducationYear = 1;
        }

        public Student(string name, int age, string gender, int weight, int year) : base(name,age,gender,weight)
        {
            AducationYear = year;
        }

        public void SetAducationYear(int year)
        {
            AducationYear = year;
        }

        public void IncAducationYear(int count)
        {
            AducationYear += count;
        }
    }
}
