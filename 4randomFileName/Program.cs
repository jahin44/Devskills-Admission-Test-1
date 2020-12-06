using System;
using System.Collections.Generic;
using System.Text;

namespace ans4_random_string
{
    class Program
    {

        static Random random = new Random();
        public static string RandomString()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz_0123456789";
            
            var sb = new StringBuilder();
            Random ran = new Random();
            for (var i = 0; i < 16; i++)
            {
                var c = chars[ran.Next(0, 60)];
                sb.Append(c);
            }
           return (sb.ToString());
        }

        static void Main(string[] args)
        {
           string name= RandomString();
            Console.WriteLine(name);
        }
    }
}
