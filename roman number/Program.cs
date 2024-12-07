using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roman_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> romanValues = new Dictionary<char, int> {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
            };
            Console.Write("enter Roman Number:");
            string s = Console.ReadLine();
            int result = 0;
            int prevValue = 0;

            for (int i = s.Length - 1; i >= 0; i--)
            {
                int value = romanValues[s[i]];
                if (value < prevValue)
                    result -= value;
                else
                    result += value;
                prevValue = value;
            }
            Console.WriteLine($"answer is:{result}");
            Console.ReadLine();

        }





    }
}
