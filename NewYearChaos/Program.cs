using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewYearChaos
{
    public class Program
    {
        public static string minimumBribes(int[] q)
        {
            string retval = string.Empty;

            int bribeCount = 0;
            int diff = 0;
            int[] idealOrder = new int[q.Length];
            for (int i = 0; i < q.Length; i++)
            {
                idealOrder[i] = i + 1;
            }

            for (int i = 0; i < q.Length; i++)
            {
                if (idealOrder[i] != q[i])
                {
                    if (idealOrder[i + 1] == q[i])
                    {
                        diff = 1;
                    }
                    else if (idealOrder[i + 2] == q[i])
                    {
                        diff = 2;
                    }
                    else
                    {
                        retval = "Too chaotic";
                        break;
                    }
   
                    bribeCount += diff;
                    //arrange ideal order
                    for (int j = i + diff; j > i; j--)
                    {
                        idealOrder[j] = idealOrder[j - 1];
                    }
                    idealOrder[i] = q[i];

                  
                }
                diff = 0;

            }
            if (retval == string.Empty)
            {
                retval = bribeCount.ToString();
            }
            Console.WriteLine(retval);
            return retval;

        }
        static void Main(string[] args)
        {

            int[] q = Array.ConvertAll("1,2,5,3,7,8,6,4 ".Split(','), qTemp => Convert.ToInt32(qTemp));
            Console.WriteLine(minimumBribes(q));
            Console.ReadLine();

        }
    }
}
