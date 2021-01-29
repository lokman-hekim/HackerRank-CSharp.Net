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

        public static int minimumSwaps1(int[] arr)
        {
            // Initialise count variable 
            int count = 0;
            int i = 0;
            while (i < arr.Length)
            {

                // If current element is 
                // not at the right position 
                if (arr[i] != i + 1)
                {

                    while (arr[i] != i + 1)
                    {
                        int temp = 0;

                        // Swap current element 
                        // with correct position 
                        // of that element 
                        temp = arr[arr[i] - 1];
                        arr[arr[i] - 1] = arr[i];
                        arr[i] = temp;
                        count++;
                    }
                }

                // Increment for next index 
                // when current element is at 
                // correct position 
                i++;
            }
            return count;
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
