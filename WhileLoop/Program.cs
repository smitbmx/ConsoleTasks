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
            runMethod -= NegativeNumbers;
            runMethod += DYAlplabet;

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

        /// <summary>
        /// Вывести в строчку буквы английского алфавита от D до Y.
        /// </summary>
        private static void DYAlplabet()
        {
            char start = 'D';
            char end = 'Y';
            int i = start;
            while (i <= end)
            {
                Console.Write(Convert.ToChar(i));
                i++;
            }

            Console.WriteLine();
        }
    }
}
