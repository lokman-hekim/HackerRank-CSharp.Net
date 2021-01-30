using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumSwaps2
{
    public class Program
    {
        public static int minimumSwaps(int[] arr)
        {
            int retVal = 0;
            int indexOfVal = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != (i + 1))
                {
                    while (arr[i] != i + 1)
                    {
                        indexOfVal = 0;
                        indexOfVal = arr[arr[i] - 1];
                        arr[arr[i] - 1] = arr[i];
                        arr[i] = indexOfVal;
                        retVal++;
                    }
                }
            }
            return retVal;
        }

        static void Main(string[] args)
        {

            int n = 7;

            int[] arr = Array.ConvertAll("1 3 5 2 4 6 7".Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
            int res = minimumSwaps(arr);

            Console.WriteLine(res);


        }
    }
}
