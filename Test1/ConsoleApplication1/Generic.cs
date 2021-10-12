using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Generic
    {
        public class SampleClass
        {
            public void GMethod<T>(T a, T b)
            {
                Console.WriteLine("Param1: {0}", a);
                Console.WriteLine("Param2: {0}", b);
            }
        }

        class Program
        {
            //static void Main(string[] args)
            //{
            //    Console.WriteLine("****Generics Method Example****");
            //    SampleClass s = new SampleClass();
            //    s.GMethod<int>(1, 2);           //Decalrtion in Int
            //    s.GMethod<string>("Anil", "Anil"); //Decalrtion in String
            //    s.GMethod("Suresh Dasari", "Hyderabad");
            //    Console.ReadLine();
            //}
        }
    }
}


