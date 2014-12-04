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
            runMethod += SumOrMultiply;

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
    }
}
