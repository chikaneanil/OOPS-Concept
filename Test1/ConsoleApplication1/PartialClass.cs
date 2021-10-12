using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public partial class User
    {
        private string name;
        private string location;
        public User()
        {

        }


        public new void GetDetails(string a, string b)
        {
            this.name = a;
            this.location = b;
            Console.WriteLine("Name :" + name);
            Console.WriteLine("Location :" + location);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            User b = new User();
            //Console.WriteLine(b.GetDetails("anil", "Mumbai"));
            //Console.WriteLine(b.GetDetails1("amit", "Pune"));
            b.GetDetails("anil", "Mumbai");
           // b.GetDetails1("amit", "Pune");
            Console.ReadLine();
        }
    }

    class Abstraction3 : Abstraction
    {
        public override void GetDetails(string x, string y)
        {
            Console.WriteLine("Name :" + x);
            Console.WriteLine("Location :" + y);
        }
    }

}
