using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Length();

            CompareTo();

            Console.ReadLine();
        }

        static void Length()
        {
            string l1 = Console.ReadLine();
            string l2 = Console.ReadLine();

            Console.WriteLine(l1.Length + " " + l2.Length);
        }

        static void CompareTo()
        {
            string l1 = Console.ReadLine();
            string l2 = Console.ReadLine();

            Console.WriteLine(l1.CompareTo(l2));
        }
    }
}
