using System;
using System.Collections.Generic;

namespace OddDigitsfile
{
    class Program
    {
        public static List<int> OddDigits()
        {
            string inputnumber = Console.ReadLine();
            List<int> output = new List<int>();            
            for (int i = 0; i < inputnumber.Length; i++)
            {
                if ((Convert.ToInt32(inputnumber[i]) % 2) != 0)
                { int a = Convert.ToInt32(inputnumber[i]);
                    output.Add(a);
                }
                                   
            }

            return output;
        }
        static void Main(string[] args)
        {
            List<int> num = new List<int>();
           
              num = OddDigits();
            foreach(int data in num)
            {
                Console.WriteLine(data);
            }
        }
    }
}
