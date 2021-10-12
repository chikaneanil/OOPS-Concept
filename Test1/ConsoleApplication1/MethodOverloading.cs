using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class MethodOverloading
    {
        public int Addition(int a, int b)
        {
            int c;
            return c = a + b;
        }
        public double Addition(double a, double b)
        {
            double d;
            return d = a + b;
        }
        public double Addition(double a, double b, double c)
        {
            double d;
            return d = a + b + c;
        }
        public double Addition(double a, double b, int c)
        {
            double d;
            return d = a + b + c;
        }

        //class program
        //{
        //    static void Main(string[] args)
        //    {
        //        MethodOverloading b = new MethodOverloading();
        //        Console.WriteLine(b.Addition(10.5, 10.5));
        //        Console.WriteLine(b.Addition(10.5, 10.5, 10));
        //        Console.WriteLine(b.Addition(10.5, 10.5, 10.5));
        //        Console.WriteLine(b.Addition(10, 10));
        //        Console.WriteLine("\nPress Enter Key to Exit..");
        //        Console.ReadLine();
        //    }
        //}
    }
}
