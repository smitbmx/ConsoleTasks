using System;
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
            runMethod -= Rectangle;
            runMethod -= LengthInterval;
            runMethod -= Discriminant;
            runMethod -= CircleSquare;
            runMethod -= CircleSquare2;
            runMethod -= SinRad;
            runMethod += ZeroZero;


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

        /// <summary>
        /// Даны координаты вершин отрезка.
        //Найти длину данного отрезка с точностью до сотых.
        //Начальные данные: по два числа на двух строчках - координаты точек.
        //Вывод результата: одно вещественное число - длина отрезка.
        /// </summary>
        private static void LengthInterval()
        {
            string[] FirstCoordinates = Console.ReadLine().Split(' ');
            string[] SecondCoordinates = Console.ReadLine().Split(' ');

            double first = double.Parse(FirstCoordinates[0]);
            double second = double.Parse(FirstCoordinates[1]);
            double third = double.Parse(SecondCoordinates[0]);
            double fourth = double.Parse(SecondCoordinates[1]);

            double height = fourth - second;
            double wide = third - first;

            double res = System.Math.Sqrt(height * height + wide * wide);

            Console.WriteLine("{0:f2}", res);
        }

        private static void Discriminant()
        {
            string[] input = Console.ReadLine().Split(' ');
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            int c = int.Parse(input[2]);

            int d = b * b - 4 * a * c;

            Console.WriteLine(d);
        }
        /// <summary>
        /// Вводятся четыре числа - 
        //координаты центра окружности и 
        //координаты одной из точек на окружности.
        //Найти площадь этого круга c точностью до сотых.
        //Начальные данные: четыре вещественных числа.
        //Вывод результата: вещественное число - площадь круга.
        /// </summary>
        private static void CircleSquare()
        {
            string[] input = Console.ReadLine().Split(' ');
            double circleSquare = 0;

            double first = double.Parse(input[0]);
            double second = double.Parse(input[1]);
            double third = double.Parse(input[2]);
            double fourth = double.Parse(input[3]);

            double height = fourth - second;
            double width = third - first;

            double radius = System.Math.Sqrt(height * height + width * width);
            circleSquare = System.Math.PI * radius * radius;

            string resultWithComa = string.Format("{0:0.00}", circleSquare);
            Console.WriteLine(resultWithComa.Replace(",", "."));
        }

        private static void CircleSquare2()
        {
            string[] input = Console.ReadLine().Split();
            double x, y, ax, ay, S;
            x = double.Parse(input[0]);
            y = double.Parse(input[1]);
            ax = double.Parse(input[2]);
            ay = double.Parse(input[3]);

            S = System.Math.PI * ((ax - x) * (ax - x) + (ay - y) * (ay - y));
            string resultWithComa = string.Format("{0:0.00}", S);
            Console.WriteLine("{0:f2}", resultWithComa.Replace(",", "."));
        }

        private static void SinRad()
        {
            double angle = double.Parse(Console.ReadLine());
            double res = 0;

            res = System.Math.Sin(angle * System.Math.PI / 180);

            Console.WriteLine("{0:f2}", res);
        }

        /// <summary>
        /// Дано натуральное число.
        //Обнулить в нем единицы и десятки.
        //Начальные данные: одно натуральное число.
        //Вывод результата: одно натуральное число
        //123 => 100
        /// </summary>
        private static void ZeroZero()
        {
            int input = int.Parse(Console.ReadLine());
            string str = input.ToString();
            int result = 0;

            int last = int.Parse(str[str.Length - 1].ToString());
            int lastLast = int.Parse(str[str.Length - 2].ToString());

            result = input - (lastLast * 10 + last);

            Console.WriteLine(result);
        }
    }
}
