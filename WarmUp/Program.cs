using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarmUp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calc();

            //Counting();

            //UncleEcho();

            //GrandfatherEcho();

            //ChinaWall();

            //ChinaWallRecursion(string.Empty);

            PostCard();

            Console.ReadLine();
        }

        static void Calc()
        {
            Console.WriteLine(12 * ((25 + 689) / (60 - 9)) - (12 * 3));
        }

        static void Counting()
        {
            string[] arr = { "One", "Two", "Three", "Four", "Five" };
            foreach (string s in arr)
            {
                Console.WriteLine(s);
            }
        }

        static void UncleEcho()
        {
            Console.WriteLine(Console.ReadLine());
        }

        static void GrandfatherEcho()
        {
            string str = Console.ReadLine();
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(str);
            }
        }

        static void ChinaWall()
        {
            string a = "#";
            a = a + a + a + a + a + a + a + a + a + a;
            a = a + a + a + a + a + a + a + a + a + a;
            a = a + a + a + a + a + a + a + a + a + a;
            Console.WriteLine(a);
        }

        static void ChinaWallRecursion(string a)
        {
            if (string.Equals(a, "stop"))
            {
                Console.ReadLine();
            }
            if (string.IsNullOrEmpty(a))
            {
                a = "#";
                ChinaWallRecursion(a);
            }
            else
            {
                a += "#";
                if (a.Length == 1000)
                {
                    Console.WriteLine(a);
                    ChinaWallRecursion("stop");
                }
                ChinaWallRecursion(a);
            }
        }

        static void PostCard()
        {
            string name = Console.ReadLine();
            string age = Console.ReadLine();
            string city = Console.ReadLine();

            Console.WriteLine(string.Format("Дорогой {0}!", name));
            Console.WriteLine(string.Format("Тебе сегодня стукнуло {0}", age));
            Console.WriteLine(string.Format("Желаем здоровья и счастья!"));
            Console.WriteLine(string.Format("{0}, будь умным и красивым!", name));
            Console.WriteLine();
            Console.WriteLine(string.Format("Жители города {0}", city));

        }
    }


}
