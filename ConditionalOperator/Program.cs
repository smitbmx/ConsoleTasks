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
            runMethod += Maximum;

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
    }
}
