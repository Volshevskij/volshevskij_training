using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thw_3._1
{
    class Man
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Gender { get; private set; }
        public int Weight { get; private set; }

        public Man()
        {
            Name = "Jim";
            Age = 19;
            Gender = "M";
            Weight = 80;
        }

        public Man(string name, int age, string gender, int weight)
        {
            Name = name;
            Age = age;
            Gender = gender;
            Weight = weight;
        }

        public void SetName(string name)
        {
            Name = name;
        }

        public void SetAge(int age)
        {
            Age = age;
        }

        public void SetWeight(int weight)
        {
            Weight = weight;
        }
    }
}
