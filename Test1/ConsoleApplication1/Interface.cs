using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{


   
    interface ICalculation
    {
        int Addition(int a, int b);
        int Substraction(int a, int b);
        int Multiply(int a, int b);
    }

    interface ICalculation1
    {
        int Multiply(int a, int b);
        int Division(int a, int b);
    }
    interface ICalculation3
    {
        int Multiply(int a, int b);
    }

    interface ICalculation4
    {
        int Multiply(string a, int b);
    }

    class Calculation : ICalculation,ICalculation3
    {
        public int Addition(int a, int b)
        {
            return a + b;
        }
        public int Substraction(int a, int b)
        {
            return a - b;
        }
        public int Multiply(int a, int b)
        {
            return a * b;
        }
    }
    class Calculation1 : ICalculation1
    {
        public int Multiply(int a, int b)
        {
            return a * b;
        }
        public int Division(int a, int b)
        {
            return a / b;
        }
        public int Addition(int a, int b)
        {
            return a + b;
        }
        public int Substraction(int a, int b)
        {
            return a - b;
        }
       

    }

    class Program1
    {
        public static void Main(string[] args)
        {
            Calculation ob = new Calculation();
            Console.WriteLine("Addition of " + ob.Addition(5, 5));
            Console.WriteLine("Substraction of " + ob.Substraction(5, 1));
            Console.WriteLine("Multiply of " + ob.Multiply(5, 5));

            Calculation1 ob1 = new Calculation1();
            Console.WriteLine("Multiplication Of " + ob1.Multiply(5, 5));
            Console.WriteLine("Division  of " + ob1.Division(5, 1));
            Console.WriteLine("Addition of " + ob1.Addition(5, 5));
            Console.WriteLine("Substraction of " + ob1.Substraction(5, 1));
            Console.ReadLine();

            ICalculation3 c1 = new Calculation();
            c1.Multiply(1, 1);

            
        }
    }
}


//Class can have any Numbers of interface.
//Interface is public.
//Interface method is defined and variables never be defined.
//Interface is used as multiple Inheritance.
//Interface dont have Constructor.
// all Method is Public and abstract in interface.
