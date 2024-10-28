using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class Dog : Pet, ITalkable
    {
        public bool IsFriendly { get; private set; }

        public Dog(bool isFriendly, string name) : base(name)
        {
            IsFriendly = isFriendly;
        }

        public string Talk()
        {
            return "Bark";
        }

        public override string ToString()
        {
            return $"Dog: Name={Name}, IsFriendly={IsFriendly}";
        }
    }
}
