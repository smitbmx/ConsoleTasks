using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearRecord
{
    class Program
    {
        private delegate void RunMethod();

        static void Main(string[] args)
        {
            RunMethod runMethod = Stub;
            runMethod -= Formula0000;
            runMethod -= Formula0001;
            runMethod += Formula0010;

            runMethod.Invoke();

            Console.ReadLine();
        }

        private static void Stub()
        {

        }

        /// <summary>
        /// Вводится вещественное число X.
        //Вычислить значение следующих функций и вывести их в столбик с точностью до 3 знаков после запятой:

        //1. | x |
        //2. sin x
        //3. cos x
        //4. π x
        //5. x 2
        //6. √ x
        //7. ln x
        //8. lg x
        //9. e x
        //0. x e
        //
        //Math Abs Sin Cos PI Pow Sqrt Log Log10 Exp
        /// </summary>
        private static void Formula0000()
        {
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("{0:0.000}", Math.Abs(x));
            Console.WriteLine("{0:0.000}", Math.Sin(x));
            Console.WriteLine("{0:0.000}", Math.Cos(x));
            Console.WriteLine("{0:0.000}", Math.PI * x);
            Console.WriteLine("{0:0.000}", Math.Pow(x, 2));
            Console.WriteLine("{0:0.000}", Math.Sqrt(x));
            Console.WriteLine("{0:0.000}", Math.Log(x));
            Console.WriteLine("{0:0.000}", Math.Log10(x));
            Console.WriteLine("{0:0.000}", Math.Exp(x));
            Console.WriteLine("{0:0.000}", Math.Pow(x, Math.E));
        }

        private static void Formula0001()
        {
            double a = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());

            double y = (Math.Pow((Math.Abs(a - x * x)) * Math.Log(a + x), 1.0 / 3.0)) / ((Math.Pow(x * x, 1.0 / 3.0)) + (Math.Pow(a, 1.0 / 5.0)));

            Console.WriteLine("{0:0.00}", y);
        }

        private static void Formula0010()
        {
            double a = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());

            double z = (Math.Pow(x * x * x, 1 / 4.0) + a * x) / (Math.Log(Math.Sqrt(a * a + Math.Sqrt(x))));

            Console.WriteLine("{0:0.0000}", z);
        }
    }
}
