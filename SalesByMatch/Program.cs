using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesByMatch
{
    public class Program
    {

        // Complete the sockMerchant function below.
        public static int sockMerchant(int n, int[] ar)
        {
            int retVal = 0;
            int cval = 0;

            Dictionary<int, int> dictEs = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
            {
                cval = ar[i];
                if (dictEs.Keys.Contains<int>(cval))
                {
                    dictEs[cval] += 1;
                }
                else
                {
                    dictEs.Add(cval, 1);
                }
            }


            foreach (var item in dictEs.Values)
            {
                retVal += item / 2;

            }



            return retVal;
        }

        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
            /*
                 10

    1 1 3 1 2 1 3 3 3 3
             */

            //int n = Convert.ToInt32(Console.ReadLine());
            int n = 12;

            int[] ar = new int[] { 10, 20, 20, 10, 10, 30, 50, 10, 20, 50, 50, 20 };

            // int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))            ;
            int result = sockMerchant(n, ar);

            Console.Write("result: " + result.ToString());
            Console.ReadLine();
            /* textWriter.WriteLine(result);

             textWriter.Flush();
             textWriter.Close();*/
        }
    }
}
