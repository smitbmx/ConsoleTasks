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
            runMethod -= NLessons;
            runMethod -= Perimeter;
            runMethod -= Square;
            runMethod -= SecondFractional;
            runMethod -= Arithmetic2;
            runMethod -= Equation2;
            runMethod -= ChickenAndEggs;
            //runMethod += Clocks;
            runMethod -= Clocks2Variand;
            runMethod += LoveToNumbers;

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

        /// <summary>
        //Даны координаты вершин треугольника (на плоскости). 
        //Найти его периметр, ответ округлить до сотых.
        //Подсказки:
        //Длина стороны AB вычисляется по формуле: корень ( (Ax-Bx)^2 + (Ay-By)^2 ).
        //Периметр вычисляется как сумма всех сторон.

        //Начальные данные: по два целых числа на трёх строчках
        //Вывод результата: одно вещественное число - периметр треугольника.
        /// </summary>
        private static void Perimeter()
        {
            string[] ACoordinate = Console.ReadLine().Split(' ');
            string[] BCoordinate = Console.ReadLine().Split(' ');
            string[] CCoordinate = Console.ReadLine().Split(' ');
            double AB = 0, BC = 0, AC = 0, perimeter = 0;

            int Ax = int.Parse(ACoordinate[0]);
            int Ay = int.Parse(ACoordinate[1]);
            int Bx = int.Parse(BCoordinate[0]);
            int By = int.Parse(BCoordinate[1]);
            int Cx = int.Parse(CCoordinate[0]);
            int Cy = int.Parse(CCoordinate[1]);

            AB = Math.Sqrt(Math.Pow(Ax - Bx, 2) + Math.Pow(Ay - By, 2));
            BC = Math.Sqrt(Math.Pow(Bx - Cx, 2) + Math.Pow(By - Cy, 2));
            AC = Math.Sqrt(Math.Pow(Ax - Cx, 2) + Math.Pow(Ay - Cy, 2));

            perimeter = Math.Round(AB + BC + AC, 2);

            Console.WriteLine("{0:f2}", perimeter);
        }

        /// <summary>
        /// Даны координаты точки на плоскости. Вычислить площадь прямоугольного треугольника с точностью до сотых, катеты которого параллельны координатным осям, а вершины — заданная точка и точки пересечения с осями координат прямых, проходящих через заданную точку и параллельных осям координат.
        //Подсказка:
        //Площадь прямоугольного прямоугольника равна полупроизведению длин его катетов.

        //Начальные данные: два вещественных числа на одной строке через пробел — координаты точки на плоскости.
        //Вывод результата: одно вещественное число — площадь прямоугольного треугольника.
        /// </summary>
        private static void Square()
        {
            string[] input = Console.ReadLine().Split(' ');

            double square = Math.Abs(double.Parse(input[0]) * double.Parse(input[1]) / 2);

            Console.WriteLine("{0:f2}", square);
        }

        /// <summary>
        /// у (после запятой) в дробной части.
        //Начальные данные: одно вещественное число.
        //Вывод результата: одн
        /// </summary>
        private static void SecondFractional()
        {
            string input = Console.ReadLine();
            string fraction = input.Split('.')[1].Substring(0, 3);

            Console.WriteLine(int.Parse(fraction[1].ToString()));
        }

        private static void SecondFraction2()
        {
            double a = double.Parse(Console.ReadLine());
            a = Math.Floor(Math.Abs(a) * 100);
            int b = Convert.ToInt32(a);
            b = b % 10;
            Console.WriteLine(b);
        }

        /// <summary>
        /// Вводится арифметическое выражение в виде: 
        //A+B*C=
        //Всегда именно в таком виде: 
        //первое число, знак сложения, второе число, знак умножения, третье число, знак равно, всё без пробелов.

        //Вывести его значение.

        //Начальные данные: арифметическое выражение по шаблону.
        //Вывод результата: одно целое число - значение арифметического выражения.
        /// </summary>
        private static void Arithmetic2()
        {
            string input = Console.ReadLine();
            int plusPos = input.IndexOf('+');
            int multiplyPos = input.IndexOf('*');
            int equalPos = input.IndexOf('=');
            long first = long.Parse(input.Substring(0, plusPos));
            long second = long.Parse(input.Substring(plusPos + 1, multiplyPos - plusPos - 1));
            long third = long.Parse(input.Substring(multiplyPos + 1, equalPos - multiplyPos - 1));

            long res = first + second * third;
            Console.WriteLine(res);
        }

        /// <summary>
        /// Дан один корень квадратного уравнения и коэффициент с.
        //Известно, что коэффициент a равен 1. Найти второй 
        //корень и коэффициент b с точностью до десятых.

        //Подсказка: 
        //Используйте теорему Виета.
        //x1 + x2 = - b
        //x1 * x2 = c

        //Начальные данные: два целых числа на строке через пробел - 
        //* первый корень квадратного уравнения
        //* коэффициент с.
        //Вывод результата: два вещественных числа с точностью до десятых - 
        //* второй корень квадратного уравнения
        //* коэффициент b.
        /// </summary>
        private static void Equation2()
        {
            string[] input = Console.ReadLine().Split();

            double x1 = double.Parse(input[0]);
            double c = double.Parse(input[1]);

            double x2 = c / x1;
            double b = (x1 + x2) * (-1);

            Console.WriteLine("{0:f1} {1:f1}", x2, b);
        }

        /// <summary>
        /// 5 кур несут 5 яиц за 5 дней.
        //Сколько яиц снесут A кур за A дней?
        //Начальные данные: одно натуральное число.
        //Вывод результата: одно натуральное число.
        /// </summary>
        private static void ChickenAndEggs()
        {
            long varialbe = long.Parse(Console.ReadLine());
            long countChicken = varialbe;
            long days = varialbe;

            long countEggs = days * countChicken / 5;

            Console.WriteLine(countEggs);
        }

        /// <summary>
        /// Дано время (часы, минуты).
        //Определить угол между часовой и минутной стрелками часов.
        //Считать, что стрелки сдвигаются один раз в минуту. 
        //Ответ должен быть не более 180 градусов.
        //Ответ записать в градусах целым числом.
        //Начальные данные: Вводятся два целых числа через пробел: H, M. (0≤H<24, 0≤M<60, M mod 2 = 0)
        //Вывод результата: Вывести число - количество градусов

        //have bugs
        /// </summary>
        private static void Clocks()
        {
            string[] input = Console.ReadLine().Split();
            int hours = int.Parse(input[0]);
            int minutes = int.Parse(input[1]);
            const int hourDegree = 30;
            const int minuteDegree = 6;

            int firstHoursDegree = 360 - hours * hourDegree;
            int secondHoursDegree = 360 - firstHoursDegree;
            int minHoursDegree = Math.Min(firstHoursDegree, secondHoursDegree);

            int firstMinutesDegree = 360 - minutes * minuteDegree;
            int secondMinuteDegree = 360 - firstMinutesDegree;
            int minMinutesDegree = Math.Min(firstMinutesDegree, secondMinuteDegree);

            int resultDegreeBetweenClocks = Math.Abs(minMinutesDegree - minHoursDegree);

            int pseudoResult = 360 - resultDegreeBetweenClocks;
            int realResult = Math.Min(resultDegreeBetweenClocks, pseudoResult);

            Console.WriteLine(realResult);
        }

        //have bugs ?
        private static void Clocks2Variand()
        {
            string[] input = Console.ReadLine().Split();
            long hours = long.Parse(input[0]);
            long minutes = long.Parse(input[1]);

            long mDegree = minutes * 6;
            long hDegree = hours * 30 + minutes / 2;

            long degree1 = Math.Abs(mDegree - hDegree);
            long degree2 = Math.Abs(mDegree - hDegree + 360);
            long degree3 = Math.Abs(mDegree - hDegree - 360);

            long answer = Math.Min(degree1, degree2);
            answer = Math.Min(answer, degree3);

            Console.WriteLine(answer);
        }

        /// <summary>
        /// Маленький мальчик очень любит цифры, они маленькие.
        //А вот числа он не очень любит, потому что они большие.
        //Поэтому когда он видит число, он сразу складывает его цифры.
        //Если получается цифра, то он радуется, потому что она маленькая.
        //А если нет, то очень огорчается и пробует снова. Пока не получится. 
        //Помогите мальчику найти окончательную маленькую цифру и обрадоваться.

        //Начальные данные: одно натуральное число.
        //Вывод результата: одно натуральное число.
        /// </summary>
        private static void LoveToNumbers()
        {

        }
    }
}
