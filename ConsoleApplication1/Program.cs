using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Square a = new Square();
            a.side = 5;
            a.Color = "Red";
            Square b = a;
            b.Color = "Pink";
            Console.WriteLine("The area of the {0} sqaure is: {1}", a.Color,
                a.CalcArea());
                //a.CalcArea(t=>t * t).ToString());
            Console.ReadKey();

            Circle c = new Circle();
            c.radius = 5;
            c.Color = "Blue";
            Console.WriteLine("The area of the {0} circle is: {1}", c.Color, c.CalcArea().ToString());
            Console.ReadKey();

            Shape s = new Square();
            Console.WriteLine("The area of the shape is: {0}", s.CalcArea().ToString());
            Console.ReadKey();
            String strval = "Hello World";
            String strval2 = strval;
            strval = "Hello Austria";
            Console.WriteLine(strval2);
            Console.ReadKey();
           
        }
    }
}
