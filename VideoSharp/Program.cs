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
            runMethod = Read;

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
    }
}
