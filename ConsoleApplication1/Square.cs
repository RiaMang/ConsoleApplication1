using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Square : Shape
    {
        public Square()
        {
            side = 3;
        }
        public int side { get; set; }

        public override int CalcArea()
        {
            return side * side;
        }

        public int CalcArea(Func<int, int> op)
        {
            return op(side);
        }
    }
}
