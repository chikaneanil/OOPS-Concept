using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    static class Static
    {
        public static string Name;
        public static string Location;

        public static void GetMain(string Name, string Location)
        {
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Location : " + Location);
            Console.ReadLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Static.Name = "Anil";
            Static.Location = "1";
            Static.GetMain(Static.Name, Static.Location);

        }
    }
}
