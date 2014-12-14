using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop
{
    class Program
    {
        private delegate void RunMethod();
        static void Main(string[] args)
        {
            RunMethod runMethod = Stub;
            runMethod -= AllNumbers;
            runMethod += NegativeNumbers;

            runMethod.Invoke();

            Console.ReadLine();
        }

        private static void Stub()
        {
        }

        private static void AllNumbers()
        {
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        private static void NegativeNumbers()
        {
            int i = -10;
            while (i >= -99)
            {
                Console.WriteLine(i);
                i--;
            }
        }
    }
}
