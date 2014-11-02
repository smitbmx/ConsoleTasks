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
            runMethod -= Typos;
            runMethod -= Classics1;
            runMethod -= Classics2;
            runMethod -= Classics4;
            runMethod -= OneAnaHalf;
            runMethod -= AppleTree;
            runMethod -= MikleMan;
            runMethod -= Arithmetician;
            runMethod -= Tram;
            runMethod += Bankirs;

            //Classics3(0, 0, null, false);

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

            long keys = 1024 * N + R * 2;

            Console.WriteLine(keys);
        }


        private static void Classics1()
        {
            string input = Console.ReadLine();
            int result = 0;

            char[] charArr = input.ToCharArray();

            foreach (char c in charArr)
            {
                result += int.Parse(c.ToString());
            }

            Console.WriteLine(result);
        }

        /// <summary>
        /// Маленькая девочка любит играть в классики. Она рисует на асфальте мелом число и прыгает по цифрам этого числа. По каждой цифре столько раз, сколько написано. Сколько раз прыгнула маленькая девочка на одном числе?
        //Начальные данные: целое число от 0 до 123456789.
        //Вывод результата: одно число.
        //Запрещенно:	if for
        /// </summary>
        private static void Classics2()
        {
            int input = int.Parse(Console.ReadLine());
            int result = 0;

            result += input % 10; input /= 10;
            result += input % 10; input /= 10;
            result += input % 10; input /= 10;
            result += input % 10; input /= 10;
            result += input % 10; input /= 10;
            result += input % 10; input /= 10;
            result += input % 10; input /= 10;
            result += input % 10; input /= 10;
            result += input % 10; input /= 10;
            result += input % 10;

            Console.WriteLine(result);
        }

        private static void Classics3(int position, int result, char[] charArr, bool flagInit)
        {
            if (!flagInit)
            {
                string input = Console.ReadLine();
                position = 0;
                charArr = input.ToCharArray();
                result = 0;
            }

            if (charArr.Length - 1 >= position)
            {
                flagInit = true;
                result += int.Parse(charArr[position].ToString());
                position++;
                Classics3(position, result, charArr, flagInit);
            }
            else
            {
                Console.WriteLine(result);
            }
        }

        private static void Classics4()
        {
            string input = Console.ReadLine();
            char[] charArr = input.ToCharArray();
            int result = 0;

            int i = 0;
            while (i <= charArr.Length - 1)
            {
                result += int.Parse(charArr[i].ToString());
                i++;
            }

            Console.WriteLine(result);
        }

        /// <summary>
        /// Если полторы курицы несут полтора яйца в полтора дня, 
        //то сколько яиц снесут N кур за N дней?
        //Начальные данные: целое число от 0 до 100.
        //Вывод результата: одно целое число.
        /// </summary>
        private static void OneAnaHalf()
        {
            string input = Console.ReadLine();

            int N = int.Parse(input);

            Console.WriteLine(N * N * 2 / 3);
        }

        /// <summary>
        /// На берёзе N1 толстых веток, на каждой толстой ветке по N2 тоненьких веточки. На каждой тоненькой веточке по N3 яблочек. Сколько всего яблок?
        //Начальные данные: три целых числа через пробел: N1 N2 N3, каждое число от 0 до 10.
        //Вывод результата: одно число.
        //Примечание: задача с подвохом.
        /// </summary>
        private static void AppleTree()
        {
            //string[] input = Console.ReadLine().Split(' ');

            //int bigBranch = int.Parse(input[0]);
            //int smallBranch = int.Parse(input[1]);
            //int apples = int.Parse(input[2]);

            //int result = bigBranch * smallBranch * apples;
            Console.WriteLine(0);
        }

        private static void MikleMan()
        {
            int oneAppleCost = 40;
            int oneGreenBoutleCost = 25;
            int countBrownBottle = 12;
            int foundMoney = 5 * 2 + 10 * 5;

            string[] input = Console.ReadLine().Split(' ');

            int countGreenBottle = int.Parse(input[0]);
            int oneBrownBottleCost = int.Parse(input[1]);

            int totalMoney = oneGreenBoutleCost * countGreenBottle + countBrownBottle * oneBrownBottleCost + foundMoney;
            int possibleBuyApples = totalMoney / oneAppleCost;
            Console.WriteLine(possibleBuyApples);
        }

        private static void Arithmetician()
        {
            string[] input = Console.ReadLine().Split(' ');
            int first = int.Parse(input[0]);
            int second = int.Parse(input[1]);


            Console.WriteLine(string.Format("{0} + {1} = {2}", first, second, first + second));
            Console.WriteLine(string.Format("{0} - {1} = {2}", first, second, first - second));
            Console.WriteLine(string.Format("{0} x {1} = {2}", first, second, first * second));
            Console.WriteLine(string.Format("{0} : {1} = {2} ({3})", first, second, first / second, first % second));
        }

        private static void Tram()
        {
            int stations = 5;
            int people = 10 - 2 + 4 - 8 + 3 + 18;
            int minutes = 10 + 15 + 7 + 30;

            Console.WriteLine(stations);
            Console.WriteLine(people);
            Console.WriteLine(string.Concat(minutes / 60, " ", minutes % 60));
        }

        private static void Bankirs()
        {
            string[] input = Console.ReadLine().Split(' ');
            int first = int.Parse(input[0]);
            int second = int.Parse(input[1]);

            Console.WriteLine(string.Concat(first + second, " ", first * second));
        }
    }
}
