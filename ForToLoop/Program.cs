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
            runMethod -= TwoDigitNumbers;
            runMethod -= Rombs;
            runMethod -= Squares;
            runMethod -= Alphabet;
            runMethod -= MultipliesNumbers;
            runMethod += QuadroLoop;

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

        /// <summary>
        /// Дано число N.
        //Вывести на экран N ромбиков в ряд.
        //Каждый ромбик состоит из 4 символов, размещённых на двух строчках:
        ///\
        //\/
        //Начальные данные: нет.
        //Вывод результата: N ромбиков на двух строчках
        /// </summary>
        private static void Rombs()
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                Console.Write("/\\");
            }

            Console.WriteLine();

            for (int i = 0; i < N; i++)
            {
                Console.Write("\\/");
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Для каждого числа от 1 до 100 вычислить квадрат и вывести их столбиком.
        //Начальные данные: нет.
        //Вывод результата: 100 чисел на 100 строчках.
        /// </summary>
        private static void Squares()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(Math.Pow(i, 2));
            }
        }

        /// <summary>
        /// Вывести в строчку английский алфавит от A до Z.
        //Подсказка: используйте для цикла переменную типа char.
        //Начальные данные: нет.
        //Вывод результата: 26 букв английского алфавита на одной строке.
        /// </summary>
        private static void Alphabet()
        {
            for (char i = 'A'; i <= 'Z'; i++)
            {
                Console.Write(i);
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Дано натуральное число N.
        //Вывести все трёхзначные числа, кратные этому числу, в столбик.
        //Решить программу без использования условного оператора if.
        //Начальные данные: нет.
        //Вывод результата: трёхзначные числа столбиком.
        /// </summary>
        private static void MultipliesNumbers()
        {
            int N = int.Parse(Console.ReadLine());
            int k;

            for (k = N; k < 100; k += N)
            { }
            for (; k <= 999; k += N)
            {
                Console.WriteLine(k);
            }
        }

        /// <summary>
        /// Дано два натуральных числа, a и b.
        //Вывести все числа от a до b,
        //которые являются точными квадратами.
        //Начальные данные: два натуральных числа на двух строчках.
        //Вывод результата: точные квадраты столбиком.
        /// </summary>
        private static void QuadroLoop()
        {
            long a = long.Parse(Console.ReadLine());
            long b = long.Parse(Console.ReadLine());

            long aS = (long)Math.Sqrt(a);
            long bS = (long)Math.Sqrt(b);

            aS = aS*aS >= a ? aS : aS + 1;

            for (long i = aS; i <= bS; i++)
            {
                long quadro = i * i;
                Console.WriteLine(quadro);
            }
        }
    }
}
