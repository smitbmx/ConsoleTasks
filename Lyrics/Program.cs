using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lyrics
{
    class Program
    {
        private delegate void RunMethod();

        static void Main(string[] args)
        {
            RunMethod runMethod = Stub;
            runMethod -= StudentV;
            runMethod -= Ogorod;
            runMethod -= Cats;
            runMethod += Typos;

            runMethod.Invoke();

            Console.ReadLine();
        }

        private static void Stub()
        {

        }

        private static void StudentV()
        {
            string[] wakeUpTime = Console.ReadLine().Split(' ');
            int hours = int.Parse(wakeUpTime[0]);
            int minutes = int.Parse(wakeUpTime[1]);

            int slept = hours * 60 + minutes;
            int left = 24 * 60 - slept;

            Console.WriteLine(slept);
            Console.WriteLine(left);
        }

        private static void Ogorod()
        {
            string[] data = Console.ReadLine().Split(' ');
            int square = int.Parse(data[0]) * 100;
            int wide = int.Parse(data[1]);

            int res = (square / wide + wide) * 2;

            Console.WriteLine(res);
        }



        /// <summary>
        /// В некотором царстве, в некотором государстве есть Г городов, в каждом городе по Д домов, в каждом доме по Э этажей и по П подъездов, в каждом подъезде на каждом этаже по К квартир, в каждой квартире по О окон. А на каждой крыше живёт по М мурзиков (котов). Сколько всего домов, квартир, окон и мурзиков в этом некотором государстве?
        //Начальные данные: на семи строчках семь натуральных чисел - 
        //Г, Д, Э, П, К, О и М, каждое не больше 10.
        //Вывод результата: четыре строчки по одному числу: 
        //количество домов, квартир, окон и мурзиков.
        //Внимание! В этой программе НУЖНО использовать русские имена переменных!
        /// </summary>
        private static void Cats()
        {
            int Г = int.Parse(Console.ReadLine());
            int Д = int.Parse(Console.ReadLine());
            int Э = int.Parse(Console.ReadLine());
            int П = int.Parse(Console.ReadLine());
            int К = int.Parse(Console.ReadLine());
            int О = int.Parse(Console.ReadLine());
            int М = int.Parse(Console.ReadLine());

            int домов = Г * Д;
            int квартир = домов * Э * П * К;
            int окон = квартир * О;
            int мурзиков = домов * М;

            Console.WriteLine(домов);
            Console.WriteLine(квартир);
            Console.WriteLine(окон);
            Console.WriteLine(мурзиков);
        }

        /// <summary>
        /// Тётя Валя любит писать письма. Племянник Женя купил ей клавиатуру, и она теперь пишет письма на клавиатуре. Однако тётя Валя часто делает опечатки, которые тут же исправляет и пишет правильно. Сколько клавиш нажала на клавиатуре тётя Валя, если она сделала R опечаток при наборе письма в N килобайт?
        //Начальные данные: два целых числа через пробел: N от 1 до 20, R от 0 до 1000.
        //Вывод результата: одно число.
        /// </summary>
        private static void Typos()
        {
            string[] data = Console.ReadLine().Split(' ');
            long N = long.Parse(data[0]);
            long R = long.Parse(data[1]);

            long keys = 1024*N + R*2;

            Console.WriteLine(keys);
        }
    }
}
