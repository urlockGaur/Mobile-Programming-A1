using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public interface ITalkable
    {
        string Talk();
        string Name { get; }
    }
}
