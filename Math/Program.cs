using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math
{
    class Program
    {
        private delegate void RunMethod();
        static void Main(string[] args)
        {
            RunMethod runMethod = Stub;
            runMethod += Cube;

            runMethod.Invoke();

            Console.ReadLine();
        }

        private static void Stub() { }

        /// <summary>
        /// Дана длина ребра куба.
        //Вычислить площадь его боковой поверхности.
        //Начальные данные: одно натуральное число - длина ребра куба.
        //Вывод результата: одно натуральное число - площадь боковой поверхности куба.
        /// </summary>
        private static void Cube()
        {
            int length = int.Parse(Console.ReadLine());

            int res = length * length * 4;

            Console.WriteLine(res);
        }
    }
}
