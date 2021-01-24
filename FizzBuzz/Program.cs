using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        public static void fizzBuzz(int n)
        {
            string msg = "";
            for (int i = 1; i <= n; i++)
            {

                if (i % 3 == 0 && i % 5 == 0)
                {
                    msg = "FizzBuzz";
                }
                else if (i % 3 == 0)
                {
                    msg = "Fizz";
                }
                else if (i % 5 == 0)
                {
                    msg = "Buzz";
                }
                else
                {
                    msg = i.ToString();
                }
                Console.WriteLine(msg);
                msg = "";
            }
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            fizzBuzz(n);
        }
    }
}
