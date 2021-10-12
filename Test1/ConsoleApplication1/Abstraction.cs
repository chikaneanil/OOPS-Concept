using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    abstract class Abstraction
    {
        public abstract void GetDetails(string x, string y);
        public abstract void GetDetails1(string x, string y);

        public void GetDetails2(string x)
        {

        }
    }

    class Abstraction1 : Abstraction
    {
        public override void GetDetails(string x, string y)
        {
            Console.WriteLine("Name :" + x);
            Console.WriteLine("Location :" + y);
        }
        public override void GetDetails1(string x, string y)
        {
            Console.WriteLine("Name :" + x);
            Console.WriteLine("Location :" + y);
        }

        public int add(int i, int j)
        {
            return i + j;
        }
    }
    class Abstraction2 : Abstraction
    {
        public override void GetDetails(string x, string y)
        {
            Console.WriteLine("Name :" + x);
            Console.WriteLine("Location :" + y);
        }
        public override void GetDetails1(string x, string y)
        {
            Console.WriteLine("Name :" + x);
            Console.WriteLine("Location :" + y);
        }
    }

    //class test
    //{
    //    public static void Main(string[] args)
    //    {
    //        Abstraction u = new Abstraction1();
    //        u.GetDetails("Anil", "Mumbai");

    //        Abstraction u2 = new Abstraction2();
    //        u2.GetDetails("Amit", "Mumbai");

    //        //Abstraction u3 = new Abstraction3();
    //        //u3.GetDetails("Sunil", "Mumbai");

    //        Console.ReadLine();
    //    }
    //}
}


//You cannot create instances of an abstract class.
//    Abstraction u = new Abstraction(); //this is not possible
//    Abstraction u = new Abstraction1(); //this is possible Derived class

//An abstract class is declared using the abstract modifier.
//    abstract class Abstraction

//An abstract class can contain abstract members or regular, nonabstract members.
//  public override void GetDetails(string x, string y)
//{
//    Console.WriteLine("Name :" + x);
//    Console.WriteLine("Location :" + y);
//}

//public int add(int i, int j)
//{
//    return i + j;
//}