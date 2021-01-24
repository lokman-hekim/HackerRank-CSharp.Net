using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpingOnTheClouds
{
    public class Program
    {
        public static int jumpingOnClouds(int[] c)
        {
            int shortestWay = 0;

            int i = 0;
            while (i < c.Length - 1)
            {
                i++;
                if (i + 1 < c.Length  && c[i + 1].Equals(0))
                {
                    shortestWay++;
                    i++;
                }
                else
                {
                    if (c[i].Equals(0))
                    {
                        shortestWay++;
                    }
                    else
                    {
                        i++;
                    }
                }

            }
            return shortestWay;

        }
        static void Main(string[] args)
        {

            int n = 7;

            int[] c = Array.ConvertAll("0 0 0 1 0 0".Split(' '), cTemp => Convert.ToInt32(cTemp));

            int result = jumpingOnClouds(c);
            Console.Write("result: " + result.ToString());
            Console.ReadLine();
        }
    }
}
