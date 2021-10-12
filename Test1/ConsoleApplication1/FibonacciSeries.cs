using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class FibonacciSeries
    {
        static int fibonacci(int n)
        {
            int firstNumber = 0, secondnumber = 1, result = 0;

            if (n == 0) return 0;
            if (n == 1) return 1;

            for (int i = 2; i <= n; i++)
            {
                result = firstNumber + secondnumber;
                firstNumber = secondnumber;
                secondnumber = result;

            }
            return result;
        }


        class Fibonacci
        {
            //static void Main(string[] args)
            //{
            //    Console.Write("Enter the length of the Fibonacci Series: ");   
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    for (int i = 0; i <= num; i++)
            //    {
            //        Console.Write("{0}",fibonacci(i));
            //    }
            //    Console.ReadLine();
            //}
        }
    }
}
