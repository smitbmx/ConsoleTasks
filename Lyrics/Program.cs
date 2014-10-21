using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lyrics
{
    class Program
    {
        private delegate void RunMethod();

        static void Main(string[] args)
        {
            RunMethod runMethod = Stub;
            runMethod += StudentV;

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

            int slept = hours*60 + minutes;
            int left = 24*60 - slept;

            Console.WriteLine(slept);
            Console.WriteLine(left);
        }
    }
}
