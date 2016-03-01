using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    abstract class Shape : IShape
    {
        public string Color { get; set; }

        public abstract int CalcArea();
    
    }
}
