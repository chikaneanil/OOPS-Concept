using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class MethodOverriding
    {
        public class BClass
        {
            public virtual void GetInfo()
            {
                Console.WriteLine("Method Overriding example" );
            }
        }

        // Derived Class
        public class DClass : BClass
        {
            public override void GetInfo()
            {
                Console.WriteLine("Welcome");
            }
        }

        //class Program
        //{
        //    static void Main(string[] args)
        //    {
        //        DClass d = new DClass();
        //        d.GetInfo();
        //        BClass b = new BClass();
        //        b.GetInfo();
        //        Console.WriteLine("\nPress Enter Key to Exit..");
        //        Console.ReadLine();
        //    }
        //}

    }
}
