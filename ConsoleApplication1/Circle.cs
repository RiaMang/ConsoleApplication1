using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Circle : Shape
    {
        public int radius {get; set;}

        public override int CalcArea()
        {
            return Convert.ToInt32(Math.PI * 2 * radius);
        }
    }
}
