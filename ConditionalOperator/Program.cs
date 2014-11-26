using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalOperator
{
    class Program
    {
        private delegate void RunMethod();
        static void Main(string[] args)
        {
            RunMethod runMethod = null;
            runMethod -= Stub;
            runMethod += Maximum;

            runMethod.Invoke();

            Console.ReadLine();
        }

        private static void Stub(){}

        private static void Maximum()
        {
            
        }
    }
}
