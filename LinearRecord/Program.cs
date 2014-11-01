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
            runMethod += Formula0000;

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

        }
    }
}
