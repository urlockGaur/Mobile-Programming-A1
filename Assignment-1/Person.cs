using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public abstract class Person
    {
        public string Name { get; }

        protected Person(string name)
        {
            Name = name;
        }
    }
}
