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

            Back();
            Console.ReadLine();
        }

        private static void Stub()
        {
        }

        private static int Factorial(int n)
        {
            return 0;
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
    }
}
