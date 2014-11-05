using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursions
{
    class Program
    {

        static void Main(string[] args)
        {

            //Console.WriteLine(Factorial(5));
            Console.WriteLine(Fibonacci(7));

            //Back();
            Console.ReadLine();
        }

        private static void Stub()
        {
        }

        private static int Factorial(int n)
        {
            if (n <= 1)
            {
                return 1;
            }

            return Factorial(n - 1) * n;
        }

        private static void Back()
        {
            string n = Console.ReadLine();
            if (n == "")
            {
                return;
            }
            Back();
            Console.WriteLine(n);
        }

        private static int Fibonacci(int n)
        {
            if (n==1 || n==2)
            {
                return 1;
            }

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
