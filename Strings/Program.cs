using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        private delegate void RunMethod();

        static void Main(string[] args)
        {
            RunMethod runMethod = Stub;
            runMethod -= Length;
            runMethod -= CompareTo;
            runMethod -= Copy;
            runMethod -= Split;
            runMethod -= ToLowerUpper;
            runMethod -= Contains;
            runMethod -= IndexOf;
            runMethod -= Insert;
            runMethod -= Remove;
            runMethod += PadLeftRight;

            runMethod.Invoke();

            Console.ReadLine();
        }

        static void Stub()
        {

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

        static void Copy()
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string temp = string.Copy(a);
            a = String.Copy(b);
            b = String.Copy(temp);

            Console.WriteLine(a);
            Console.WriteLine(b);
        }

        static void Split()
        {
            string words = Console.ReadLine();

            string[] arrWords = words.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            //foreach (string arrWord in arrWords)
            //{
            //    Console.WriteLine(arrWord);
            //}

            Console.WriteLine(arrWords[0]);
            Console.WriteLine(arrWords[1]);
            Console.WriteLine(arrWords[2]);
            Console.WriteLine(arrWords[3]);
            Console.WriteLine(arrWords[4]);
        }

        static void ToLowerUpper()
        {
            string a = Console.ReadLine().ToLower();
            string b = Console.ReadLine().ToLower();

            Console.WriteLine(string.Equals(a, b));
        }

        static void Contains()
        {
            string animals = Console.ReadLine().ToLower();
            string an1 = Console.ReadLine().ToLower();
            string an2 = Console.ReadLine().ToLower();
            string an3 = Console.ReadLine().ToLower();
            string an4 = Console.ReadLine().ToLower();
            string an5 = Console.ReadLine().ToLower();

            Console.WriteLine(animals.Contains(an1));
            Console.WriteLine(animals.Contains(an2));
            Console.WriteLine(animals.Contains(an3));
            Console.WriteLine(animals.Contains(an4));
            Console.WriteLine(animals.Contains(an5));
        }

        static void IndexOf()
        {
            string str = Console.ReadLine();
            int first = str.IndexOf(' ');
            int last = str.LastIndexOf(' ');

            Console.WriteLine(string.Concat(first, " ", last));
        }

        static void Insert()
        {
            string str = Console.ReadLine();
            string word = Console.ReadLine() + " ";

            int firstWordPosition = str.IndexOf(' ');
            str = str.Insert(firstWordPosition + 1, word);

            Console.WriteLine(str);
        }

        private static void Remove()
        {
            string phrase = Console.ReadLine();

            int openBracketPosition = phrase.IndexOf('(');
            int closeBracketPosition = phrase.IndexOf(')');
            int countToRemove = closeBracketPosition - openBracketPosition;
            phrase = phrase.Remove(openBracketPosition + 1, countToRemove - 1);

            Console.WriteLine(phrase);
        }

        private static void PadLeftRight()
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            string third = Console.ReadLine();
            string fourth = Console.ReadLine();
            string fifth = Console.ReadLine();
            string sixth = Console.ReadLine();
            string seventh = Console.ReadLine();

            int width = 8;

            Console.WriteLine(string.Concat(first.PadRight(width), first.PadLeft(width)));
            Console.WriteLine(string.Concat(second.PadRight(width), second.PadLeft(width)));
            Console.WriteLine(string.Concat(third.PadRight(width), third.PadLeft(width)));
            Console.WriteLine(string.Concat(fourth.PadRight(width), fourth.PadLeft(width)));
            Console.WriteLine(string.Concat(fifth.PadRight(width), fifth.PadLeft(width)));
            Console.WriteLine(string.Concat(sixth.PadRight(width), sixth.PadLeft(width)));
            Console.WriteLine(string.Concat(seventh.PadRight(width), seventh.PadLeft(width)));
        }
    }
}
