using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pattern1(5);
        }

        //pattern printer
        private static void Pattern1(int lineNumber)
        {
            /*
            1
            12
            123
            1234
            12345
             */
            string str = "";
            int lineNo = lineNumber;
            for (int i = 1; i <= lineNo; i++)
            {
                str = "";
                for(int j = 1; j <= i; j++)
                {
                    str +=j;
                }
                Console.WriteLine(str);
            }
            Console.ReadKey();

        }
    }
}
