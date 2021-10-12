using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    //sealed public class Call
    public class Call
    {
        public string name = "Suresh Dasari";
        public string location = "Hyderabad";
        public void GetInfo()
        {
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Location: {0}", location);
        }
    }
    //// Derived Class
    public class Details : Call
    {
        public int age = 32;
        public void GetAge()
        {
            Console.WriteLine("Age: {0}", age);
        }
    }

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Details d = new Details();
    //        d.GetAge();
    //        d.GetInfo();
    //        Console.WriteLine("\nPress Enter Key to Exit..");
    //        Console.ReadLine();
    //    }
    //}


    public class A
    {
        public virtual void GetInfo()
        {
            Console.WriteLine("Base Class A Method");
        }
        public virtual void Test()
        {
            Console.WriteLine("Base Class A Test Method");
        }
    }

    public sealed class B : A
    {
        public override void GetInfo()
        {
            Console.WriteLine("Derived Class B Method");
        }

        public override void Test()
        {
            Console.WriteLine("Derived Class B Test Method");
        }
    }

    //public class C : B
    //{
    //    // Compile time error
    //    public override void GetInfo()
    //    {
    //        Console.WriteLine("Derived Class B Method");
    //    }

    //    public override void Test()
    //    {
    //        Console.WriteLine("Derived Class C Test Method");
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        B b = new B();
    //        b.GetInfo();
    //        b.Test();
    //        Console.WriteLine("\nPress Enter Key to Exit..");
    //        Console.ReadLine();
    //    }
    //}

}

