using System;
using System.Collections.Generic;

namespace DSA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pattern1(5);
            Pattern2(5);
            Pattern3(5);
            int[] output = TwoSum(new int[] { 2, 7, 11, 15 }, 9);
            Console.WriteLine($"{output[0]} , {output[1]}");
            int op = RomanToInt("III");
            Console.ReadKey();
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
                for (int j = 1; j <= i; j++)
                {
                    str += j;
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(str);
            }

        }
        private static void Pattern2(int lineNumber)
        {
            /*
             *
             **
             ***
             ****
             *****
             */
            string pattern;
            for (int i = 1; i <= lineNumber; i++)
            {
                pattern = "";
                for (int j = 1; j <= i; j++)
                {
                    pattern += "*";
                }
                Console.WriteLine(pattern);
            }
        }
        /*
         *     *
         *    ***
         *   *****
         *  *******
         * *********
         */
        private static void Pattern3(int lineNumber)
        {
            string pattern = "";
            for (int i = 1; i <= lineNumber; i++)
            {
                //pattern = "";
                for (int j = i; j < lineNumber; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                //Console.WriteLine(pattern);
            }

        }
        public static int[] TwoSum(int[] nums, int target)
        {
            int[] output = new int[2];
            int sum;
            int index1, index2;
            for (int i = 0; i <= nums.Length - 1; i++)
            {
                index1 = i;
                output[0] = index1;
                for (int j = 0; j <= nums.Length - 1; j++)
                {
                    if (j == i)
                    {
                        continue;
                    }
                    sum = nums[i] + nums[j];
                    if (sum == target)
                    {
                        index2 = j;
                        output[1] = index2;
                        return output;
                    }
                }


            }

            return output;
        }

        Dictionary<string, string> map = new Dictionary<string, string>();
        public static int RomanToInt(string s)
        {
            Dictionary<char, int> romanValues = new Dictionary<char, int>
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

            int total = 0;
            int prevValue = 0;

            foreach (char c in s)
            {
                int currentValue = romanValues[c];

                if (currentValue > prevValue)
                {
                    total += currentValue - 2 * prevValue;
                }
                else
                {
                    total += currentValue;
                }

                prevValue = currentValue;
            }

            return total;
        }
    }
}
