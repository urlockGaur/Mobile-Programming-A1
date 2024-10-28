using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class Teacher : Person, ITalkable
    {
        public int Age { get; private set; }

        public Teacher(int age, string name) : base(name)
        {
            Age = age;
        }

        public string Talk()
        {
            return "Don't forget to do the assigned reading!";
        }
    }

}
