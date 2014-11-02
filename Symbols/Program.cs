using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Symbols
{
    class Program
    {
        private delegate void RunMethod();
        static void Main(string[] args)
        {
            RunMethod runMethod = Stub;
            runMethod += VideoSharp;

            runMethod.Invoke();

            Console.ReadLine();
        }

        private static void Stub() { }

        /// <summary>
        /// Вывести на экран символы с кодами:
        //86 105 100 101 111 32 83 104 97 114 112
        //Начальные данные: нет.
        //Вывод результата: символы в строку.
        /// </summary>
        private static void VideoSharp()
        {
            List<Char> lstChar = new List<char>();
            lstChar.Add(Convert.ToChar(86));
            lstChar.Add(Convert.ToChar(105));
            lstChar.Add(Convert.ToChar(100));
            lstChar.Add(Convert.ToChar(101));
            lstChar.Add(Convert.ToChar(111));
            lstChar.Add(Convert.ToChar(32));
            lstChar.Add(Convert.ToChar(83));
            lstChar.Add(Convert.ToChar(104));
            lstChar.Add(Convert.ToChar(97));
            lstChar.Add(Convert.ToChar(114));
            lstChar.Add(Convert.ToChar(112));

            string res = string.Empty;

            foreach (char c in lstChar)
            {
                res += c;
            }

            Console.WriteLine(res);
        }
    }
}
