using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Constructor
    {
        public string name, location;
        

        // Default Constructor
        public Constructor()
        {
            name = "Anil";
            location = "Mumbai";
        }
       

        //Parameterized Constructor
        public Constructor(string a, string b)
        {
            name = a;
            location = b;
        }

        //Copy Constructor
        public Constructor(Constructor Copy)
        {
            name = Copy.name;
            location = Copy.location;
        }

        // Static Constructor
        
    }
    class Main1
    {
        static void Main(string[] args)
        {
            Constructor c = new Constructor();
            Console.WriteLine("Default Constructor");//// Default Constructor
            Console.WriteLine(c.name);
            Console.WriteLine(c.location);
            Console.WriteLine("////////////////////////////////////////////////");

            //Parameterized Constructor
            Constructor c1 = new Constructor("Amit", "Mumbai");
            Console.WriteLine("Parameterized Constructor");
            Console.WriteLine(c1.name);
            Console.WriteLine(c1.location);
            Console.WriteLine("////////////////////////////////////////////////");

            //Copy Constructor
            Constructor c2 = new Constructor(c1);
            Console.WriteLine("Copy Constructor");
            Console.WriteLine(c2.name);
            Console.WriteLine(c2.location);
            Console.WriteLine("////////////////////////////////////////////////");
            Console.ReadLine();
        }
    }

}
