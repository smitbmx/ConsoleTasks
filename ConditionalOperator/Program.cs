using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalOperator
{
    class Program
    {
        private delegate void RunMethod();
        static void Main(string[] args)
        {
            RunMethod runMethod = null;
            runMethod -= Stub;
            runMethod -= Maximum;
            runMethod -= BigDifference;
            runMethod -= LessEqualMore;
            runMethod -= ThreeNumbers;
            runMethod -= Module;
            runMethod -= SumOrMultiply;
            runMethod -= EvenOrOdd;
            runMethod -= NineNumbers;
            runMethod -= NegativeCube;
            runMethod += LastDigit;

            runMethod.Invoke();

            Console.ReadLine();
        }

        private static void Stub() { }

        /// <summary>
        /// Вводятся 2 числа. 
        //Опредилть максимальное из этих чисел.
        //Если числа равны - выбрать любое.

        //Решить задачу двумя способами:
        //1. Используя условный оператор if
        //2. Используя тринарный оператор ? :

        //Начальные данные: два целых числа на двух строчках.
        //Вывод результата: дважды максимальное число на двух строках.
        /// </summary>
        private static void Maximum()
        {
            long first = long.Parse(Console.ReadLine());
            long second = long.Parse(Console.ReadLine());

            long bigger1 = first > second ? first : second;
            long bigger2;
            if (first > second)
            {
                bigger2 = first;
            }
            else
            {
                bigger2 = second;
            }

            Console.WriteLine(bigger1);
            Console.WriteLine(bigger2);
        }

        /// <summary>
        /// Вводятся 2 числа. 
        //Из большего отнять меньшее и записать результат.

        //Начальные данные: два целых числа на одной строке через пробел.
        //Диапазон значений: каждое число от -109 до 109.
        //Вывод результата: одно число - найденная разность.
        /// </summary>
        private static void BigDifference()
        {
            string[] input = Console.ReadLine().Split();
            long first = long.Parse(input[0]);
            long second = long.Parse(input[1]);

            long bigger, smaller;
            bigger = first > second ? first : second;
            smaller = first > second ? second : first;

            long res = bigger - smaller;
            if (true)
            {

            }

            Console.WriteLine(res);
        }

        /// <summary>
        /// Вводятся 2 числа. Сравнить их.
        //Вывести знак <, > или =.

        //Начальные данные: два целых числа на одной строке через пробел.
        //Диапазон значений: каждое число от -109 до 109.
        //Вывод результата: знак <, > или =.
        /// </summary>
        private static void LessEqualMore()
        {
            string[] input = Console.ReadLine().Split();
            long first = long.Parse(input[0]);
            long second = long.Parse(input[1]);

            string res = "=";
            if (first > second)
            {
                res = ">";
            }
            if (first < second)
            {
                res = "<";
            }
            Console.WriteLine(res);
        }

        /// <summary>
        /// Вводятся 3 числа.
        //Проверить равны ли они.
        //Вывести 'YES' - если они равны, 'NO' - в противном случае.

        //Начальные данные: три целых числа на одной строке через пробел.
        //Диапазон значений: каждое число от -109 до 109.
        //Вывод результата: YES или NO.
        /// </summary>
        private static void ThreeNumbers()
        {
            string[] input = Console.ReadLine().Split();
            long first = long.Parse(input[0]);
            long second = long.Parse(input[1]);
            long third = long.Parse(input[2]);

            if ((first == second) && (second == third))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }

        /// <summary>
        /// Дано число.
        //Найти его модуль.

        //Начальные данные: целое число.
        //Диапазон значений: число от -1018 до 1018.
        //Вывод результата: модуль числа.
        //Обязательно:	if
        //Запрещено:	Math
        /// </summary>
        private static void Module()
        {
            long input = long.Parse(Console.ReadLine());

            if (input < 0)
            {
                input = -input;
            }

            Console.WriteLine(input);
        }

        /// <summary>
        /// Вводятся 7 чисел. Что больше их сумма или произведение?
        //Вывести "+" или "*". Если одинаковы, вывести "=".
        //Начальные данные: семь целых чисел через пробел.
        //Диапазон значений: каждое число от -1018 до 1018.
        //Вывод результата: знак +, * или =.
        /// </summary>
        private static void SumOrMultiply()
        {
            string[] input = Console.ReadLine().Split();

            long first = long.Parse(input[0]);
            long second = long.Parse(input[1]);
            long third = long.Parse(input[2]);
            long fourth = long.Parse(input[3]);
            long fifth = long.Parse(input[4]);
            long sixth = long.Parse(input[5]);
            long seventh = long.Parse(input[6]);

            long sum = first + second + third + fourth + fifth + sixth + seventh;
            long multiply = first * second * third * fourth * fifth * sixth * seventh;
            string res = "=";

            if (sum > multiply)
            {
                res = "+";
            }
            if (multiply > sum)
            {
                res = "*";
            }

            Console.WriteLine(res);
        }

        /// <summary>
        /// Вводится 1 число.
        //Умножить его на 2, если оно нечётное,
        //или поделить его на 2, если оно чётное.

        //Начальные данные: 1 число.
        //Диапазон значений: число от -1018 до 1018.
        //Вывод результата: 1 число - результат деления или умножения.
        /// </summary>
        private static void EvenOrOdd()
        {
            long input = long.Parse(Console.ReadLine());

            long res = input % 2 == 0 ? input / 2 : input * 2;
            Console.WriteLine(res);
        }

        /// <summary>
        /// Вводятся 9 чисел.
        //Вывести в столбец только отрицательные.
        //Начальные данные: 9 чисел на одной строке через пробел.
        //Диапазон значений: каждое число от -109 до 109.
        //Вывод результата: отрицательные числа в столбец.
        /// </summary>
        private static void NineNumbers()
        {
            string[] input = Console.ReadLine().Split();

            if (long.Parse(input[0]) < 0) { Console.WriteLine(input[0]); }
            if (long.Parse(input[1]) < 0) { Console.WriteLine(input[1]); }
            if (long.Parse(input[2]) < 0) { Console.WriteLine(input[2]); }
            if (long.Parse(input[3]) < 0) { Console.WriteLine(input[3]); }
            if (long.Parse(input[4]) < 0) { Console.WriteLine(input[4]); }
            if (long.Parse(input[5]) < 0) { Console.WriteLine(input[5]); }
            if (long.Parse(input[6]) < 0) { Console.WriteLine(input[6]); }
            if (long.Parse(input[7]) < 0) { Console.WriteLine(input[7]); }
            if (long.Parse(input[8]) < 0) { Console.WriteLine(input[8]); }
        }

        /// <summary>
        /// Вводится отрицательное число, возвести его в куб.
        //Если оно неотрицательное, вывести надпись ERROR.
        //Начальные данные: 1 число.
        //Диапазон значений: число от -1018 до 1018.
        //Вывод результата: 1 число либо надпись ERROR.
        /// </summary>
        private static void NegativeCube()
        {
            long input = long.Parse(Console.ReadLine());

            if (input >= 0)
            {
                Console.WriteLine("ERROR");
            }
            else
            {
                Console.WriteLine(Math.Pow(input, 3));
            }
        }

        /// <summary>
        /// Даны два целых числа.
        //Верно ли, что они заканчиваются на одну и ту же цифру?
        //Напечатать YES, если это так, и NO, если это не так.

        //Начальные данные: 2 числа на двух строках.
        //Диапазон значений: каждое число от -1018 до 1018.
        //Вывод результата: надпись YES или NO.
        /// </summary>
        private static void LastDigit()
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();

            int ff = int.Parse(first[first.Length - 1].ToString());
            int ss = int.Parse(second[second.Length - 1].ToString());

            if (ff == ss)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
