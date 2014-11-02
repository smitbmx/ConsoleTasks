﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
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
            runMethod -= Cube;
            runMethod -= Circle;
            runMethod -= StopWatch;
            runMethod -= Geometric;
            runMethod += Rectangle;

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

        /// <summary>
        /// Дана длина окружности. Найти площадь данного круга. С точностью до сотых.
        //В качестве числа π используйте стандартную константу PI.
        //Начальные данные: одно действительные (вещественное) число - длина окружности.
        //Вывод результата: одно действительное (вещественное) число - площадь круга.
        /// </summary>
        private static void Circle()
        {
            double circleLength = double.Parse(Console.ReadLine());
            double radius = circleLength / (2.0 * System.Math.PI);

            double circleSquare = System.Math.PI * radius * radius;

            Console.WriteLine("{0:0.00}", circleSquare);
        }

        /// <summary>
        /// Дано количество секунд с начала суток.
        //Найти, сколько времени покажут часы через указанное количество секунд:
        //часов (0-23), минут (0-59) и секунд (0-59).
        //Начальные данные: одно натуральное число - количество секунд.
        //Вывод результата: три натуральных числа на строке через пробел.
        /// </summary>
        private static void StopWatch()
        {
            long totalSeconds = long.Parse(Console.ReadLine());

            long seconds = totalSeconds % 60;
            long minutes = totalSeconds / 60 % 60;
            long hours = totalSeconds / 3600 % 24;

            Console.WriteLine(string.Concat(hours, " ", minutes, " ", seconds));
        }

        /// <summary>
        /// Даны два вещественных числа.
        //Вычислить среднее геометрическое их модулей с точностью до сотых. 
        //Среднее геометрическое двух чисел - это корень их произведения.
        //Модуль числа       |x|       Math.Abs (x)
        //Корень числа       √x        Math.Sqrt (x)
        //Начальные данные: два вещественных числа.
        //Вывод результата: одно вещественное число.
        /// </summary>
        private static void Geometric()
        {
            string[] input = Console.ReadLine().Split(' ');
            double x = System.Math.Abs(double.Parse(input[0]));
            double y = System.Math.Abs(double.Parse(input[1]));

            double res = System.Math.Sqrt(x * y);

            Console.WriteLine("{0:f2}", res);
        }

        /// <summary>
        /// Даны координаты левой нижней и правой верхней вершин прямоугольника.
        //Найти его площадь.
        //Начальные данные: четыре целых числа на строке через пробел.
        //Вывод результата: одно целое число.
        /// </summary>
        private static void Rectangle()
        {
            string[] input = Console.ReadLine().Split(' ');
            int first = int.Parse(input[0]);
            int second = int.Parse(input[1]);
            int third = int.Parse(input[2]);
            int fourth = int.Parse(input[3]);

            int height = fourth - second;
            int wide = third - first;

            int res = height * wide;

            Console.WriteLine(res);
        }
    }
}