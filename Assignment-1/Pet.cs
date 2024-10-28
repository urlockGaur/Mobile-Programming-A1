using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public abstract class Pet
    {
        public string Name { get; }

        protected Pet(string name)
        {
            Name = name;
        }
    }
}
