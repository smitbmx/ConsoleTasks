using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullTasks
{
    class Program
    {
        private delegate void RunMethod();
        static void Main(string[] args)
        {
            RunMethod runMethod = Stub;
            runMethod -= Arithmetic;
            runMethod -= Equation;
            runMethod += NLessons;

            runMethod.Invoke();

            Console.ReadLine();
        }

        private static void Stub() { }

        /// <summary>
        /// Вводится арифметическое выражение в виде: 
        //A*B=
        //Всегда именно в таком виде: 
        //первое число, знак умножения, второе число, знак равно, без пробелов.

        //Вычислить и вывести значение выражения.


        //Начальные данные: арифметическое выражение с операцией умножения.
        //Вывод результата: одно целое число - значение арифметического выражения.
        /// </summary>
        private static void Arithmetic()
        {
            string input = Console.ReadLine();
            int starPosition = input.IndexOf('*');
            int equalPosition = input.IndexOf('=');

            long n1 = long.Parse(input.Substring(0, starPosition));
            long n2 = long.Parse(input.Substring(starPosition + 1, equalPosition - starPosition - 1));

            Console.WriteLine(n1 * n2);
        }

        /// <summary>
        /// Вводятся коэффициенты а и b уравнения ax + b = 0 (a ≠ 0).
        //Найти решение этого уравнения с точностью до десятых.
        //Подсказка: x = - b / a.
        //Начальные данные: два вещественных числа.
        //Вывод результата: одно вещественное число - x.
        /// </summary>
        private static void Equation()
        {
            string[] input = Console.ReadLine().Split(' ');
            double a = double.Parse(input[0]);
            double b = double.Parse(input[1]);
            double x = -(b) / a;


            Console.WriteLine("{0:f1}", x);
        }

        /// <summary>
        //        /// В школе уроки начинаются в восемь часов утра.
        //У Вовочки сегодня N уроков (N > 0).
        //Каждый урок длится 45 минут, между уроками перемены по 10 минут.
        //В какое время Вовочка будет свободен от уроков?

        //Начальные данные: На первой строке записано количество уроков, целое число от 0 до 20.
        //Вывод результата: Записать время окончания уроков в виде HH:MM.
        /// </summary>
        private static void NLessons()
        {
            int countLessons = int.Parse(Console.ReadLine());
            int defaultTime = 8 * 60;
            int lessons = 45 * countLessons;
            int breaks = (countLessons - 1) * 10;
            breaks = countLessons == 0 ? 0 : breaks;

            int totalMinutes = defaultTime + lessons + breaks;

            int hours = totalMinutes / 60 % 24;
            int minutes = totalMinutes % 60;
            Console.WriteLine("{0:00}:{1:00}", hours, minutes);
        }
    }
}
