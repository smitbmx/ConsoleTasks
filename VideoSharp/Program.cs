using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoSharp
{
    class Program
    {
        private delegate void RunMethod();

        static void Main(string[] args)
        {
            RunMethod runMethod = Stub;
            runMethod -= Maxima;
            runMethod -= Read;
            runMethod -= TwoNumbers;
            runMethod -= Division;
            runMethod -= FiveNumbers;
            runMethod += Pyramid;

            runMethod.Invoke();

            Console.ReadLine();
        }

        private static void Stub()
        {
        }

        private static void Maxima()
        {
            Console.WriteLine(string.Concat("sbyte ", sbyte.MinValue, " ", sbyte.MaxValue));
            Console.WriteLine(string.Concat("byte ", byte.MinValue, " ", byte.MaxValue));
            Console.WriteLine(string.Concat("short ", short.MinValue, " ", short.MaxValue));
            Console.WriteLine(string.Concat("ushort ", ushort.MinValue, " ", ushort.MaxValue));
            Console.WriteLine(string.Concat("int ", int.MinValue, " ", int.MaxValue));
            Console.WriteLine(string.Concat("uint ", uint.MinValue, " ", uint.MaxValue));
            Console.WriteLine(string.Concat("long ", long.MinValue, " ", long.MaxValue));
            Console.WriteLine(string.Concat("ulong ", ulong.MinValue, " ", ulong.MaxValue));
        }

        private static void Read()
        {
            string firstStr = Console.ReadLine();
            string secondStr = Console.ReadLine();
            string thirdStr = Console.ReadLine();

            int firstDgt = Convert.ToInt32(firstStr) + 1;
            int secondDgt = int.Parse(secondStr) + 1;
            int thirdDgt = 0;
            int.TryParse(thirdStr, out thirdDgt);
            thirdDgt = thirdDgt + 1;

            Console.WriteLine(string.Concat(firstDgt, " ", secondDgt, " ", thirdDgt));
        }

        private static void TwoNumbers()
        {
            string twoNumbersStr = Console.ReadLine();
            string[] numbersString = twoNumbersStr.Split(' ');
            int first = int.Parse(numbersString[0]);
            int second = int.Parse(numbersString[1]);

            Console.WriteLine(first + second);
        }

        private static void Division()
        {
            long first = long.Parse(Console.ReadLine());
            long second = long.Parse(Console.ReadLine());

            long full = first / second;
            long remainder = first % second;

            Console.WriteLine(string.Format("{0} / {1} = {2}", first, second, full));
            Console.WriteLine(string.Format("{0} % {1} = {2}", first, second, remainder));
        }

        private static void FiveNumbers()
        {
            string[] numbers = Console.ReadLine().Split(' ');

            long sum = 0;
            //foreach (string number in numbers)
            //{
            //    sum += ulong.Parse(number);
            //}

            sum = long.Parse(numbers[0]) + long.Parse(numbers[1]) + long.Parse(numbers[2]) + long.Parse(numbers[3]) + long.Parse(numbers[4]);

            Console.WriteLine(sum);
        }

        private static void Pyramid()
        {
            string[] firstArr = Console.ReadLine().Split(' ').Where(x => !string.IsNullOrEmpty(x)).ToArray();
            string[] secondArr = Console.ReadLine().Split(' ').Where(x => !string.IsNullOrEmpty(x)).ToArray(); ;
            string[] thirdArr = Console.ReadLine().Split(' ').Where(x => !string.IsNullOrEmpty(x)).ToArray(); ;
            string[] fourthArr = Console.ReadLine().Split(' ').Where(x => !string.IsNullOrEmpty(x)).ToArray(); ;
            string[] ffthArr = Console.ReadLine().Split(' ').Where(x => !string.IsNullOrEmpty(x)).ToArray(); ;

            string first = firstArr[firstArr.Length - 1];
            string second = secondArr[secondArr.Length - 1];
            string third = thirdArr[thirdArr.Length - 1];
            string fourth = fourthArr[fourthArr.Length - 1];
            string ffth = ffthArr[ffthArr.Length - 1];

            int firstNum, secondNum, thirdNum, fourthNum, ffthNum;

            int.TryParse(first, out firstNum);
            int.TryParse(second, out secondNum);
            int.TryParse(third, out thirdNum);
            int.TryParse(fourth, out fourthNum);
            int.TryParse(ffth, out ffthNum);

            Console.WriteLine(string.Concat(firstNum, " ", secondNum, " ", thirdNum, " ", fourthNum, " ", ffthNum));
            Console.WriteLine(firstNum + secondNum + thirdNum + fourthNum + ffthNum);
        }
    }
}
