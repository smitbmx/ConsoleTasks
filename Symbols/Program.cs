using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
            runMethod -= VideoSharp;
            runMethod -= Visaginas;
            runMethod -= LiteralCodes;
            runMethod -= CodeLiterals;
            runMethod += NextSymbols;

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

        private static void Visaginas()
        {
            char[] input = "Visaginas".ToCharArray();

            string res = string.Empty;
            foreach (char c in input)
            {
                res += (int)c + " ";
            }

            Console.WriteLine(res.Trim());
        }

        /// <summary>
        /// Вводится 5 символов - слово.
        //Вывести в строчку коды букв этого слова.
        //Начальные данные: слово из 5 символов.
        //Вывод результата: пять чисел через пробел
        /// </summary>
        private static void LiteralCodes()
        {
            char[] input = Console.ReadLine().ToCharArray();

            string res = string.Empty;
            int i = 0;
            foreach (char c in input)
            {
                if (i >= 5)
                {
                    break;
                }
                res += (int)c + " ";
                i++;
            }

            Console.WriteLine(res.Trim());
        }

        /// <summary>
        /// Вводится 7 символьных кодов через пробел.
        //Вывести на экран текст, состоящее из символов этих кодов.
        //Начальные данные: 7 символьных кодов через пробел.
        //Вывод результата: текст в одно слово.
        /// </summary>
        private static void CodeLiterals()
        {
            string[] input = Console.ReadLine().Split(' ');

            string res = string.Empty;

            int i = 0;
            foreach (string s in input)
            {
                if (i >= 7)
                {
                    break;
                }
                res += Convert.ToChar(int.Parse(s));
                i++;
            }

            Console.WriteLine(res);
        }

        /// <summary>
        /// Вводится символ.
        //Вывести в строчку этот и следующие
        //за ним пять символов по таблице ASCII.
        //Начальные данные: один символ.
        //Вывод результата: шесть символов в строчку через пробел.
        /// </summary>
        private static void NextSymbols()
        {
            char input = Convert.ToChar(Console.ReadLine());

            string res = string.Empty;
            for (int i = 0; i <= 5; i++)
            {
                res += input + " ";
                input++;
            }

            Console.WriteLine(res.Trim());
        }
    }
}
