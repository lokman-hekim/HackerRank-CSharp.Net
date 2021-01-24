using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysLeftRotation
{
    public class Program
    {
        public static int[] rotLeft(int[] a, int d)
        {
            int[] retVal = new int[a.Length];

            int j = 0;
            for (int i = d; i < a.Length; i++)
            {
                retVal[j] = a[i];
                j++;
            }
            for (int k = 0; k < d; k++)
            {
                retVal[j] = a[k];
                j++;
            }

            return retVal;

        }
        static void Main(string[] args)
        {

            int d = 4;

            int[] a = Array.ConvertAll("1 2 3 4 5".Split(' '), aTemp => Convert.ToInt32(aTemp));
            int[] result = rotLeft(a, d);

            string strResult = "";
            for (int i = 0; i < result.Length; i++)
            {
                strResult += result[i] + " ";

            }
            Console.Write("result: " + strResult.ToString());
            Console.ReadLine();
        }
    }
}
