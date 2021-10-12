using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Inheritance
    {
        public void Method1()
        {
            Console.WriteLine("Inheritance");
        }
    }
    class SingleInheritance :Inheritance
    {
        public void Method2()
        {
            Console.WriteLine("Single Level Inheritance");
        }
    }

    class MultipleInheritance : Inheritance
    {
        public void Method3()
        {
            Console.WriteLine("Multiple Inheritance");
        }
    }


    class MultilevelInheritance : MultipleInheritance
    {
        public void Method4()
        {
            Console.WriteLine("Multilevel Inheritance");
        }
    }
    //class Multiple
    //{
    //    static void Main(string[] args)
    //    {
    //        SingleInheritance a = new SingleInheritance();
    //        a.Method1();
    //        a.Method2();

    //        MultipleInheritance b = new MultipleInheritance();
    //        b.Method1();
    //        b.Method3();


    //        MultilevelInheritance c = new MultilevelInheritance();
    //        c.Method1();
    //        //c.Method2();
    //        c.Method3();
    //        c.Method4();


    //        //Not Possible
    //      MultipleInheritance d = new MultipleInheritance();
    //        //d.Method4();
    //        Console.ReadLine();
    //    }
    //}

}
