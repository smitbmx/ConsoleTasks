using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForToLoop
{
    class Program
    {
        private delegate void RunMethod();
        static void Main(string[] args)
        {
            RunMethod runMethod = Stub;
            runMethod -= Stars;
            runMethod -= ThreeDigitNumbers;
            runMethod += TwoDigitNumbers;

            runMethod.Invoke();

            Console.ReadLine();
        }

        private static void Stub() { }

        private static void Stars()
        {
            for (int i = 0; i < 20; i++)
            {
                Console.Write("*");
            }
        }

        /// <summary>
        /// Вывести все трёхзначные числа в столбик.
        //Начальные данные: нет.
        //Вывод результата: 900 чисел на 900 строчках.
        /// </summary>
        private static void ThreeDigitNumbers()
        {
            for (int i = 100; i <= 999; i++)
            {
                Console.WriteLine(i);
            }
        }

        /// <summary>
        /// Вывести все двухзначные числа в порядке убывания, в столбик.
        //Начальные данные: нет.
        //Вывод результата: 90 чисел на 90 строчках.
        /// </summary>
        private static void TwoDigitNumbers()
        {
            for (int i = 99; i >= 10; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
