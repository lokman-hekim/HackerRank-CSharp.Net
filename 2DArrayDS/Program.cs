using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DArrayDS
{
    class Program
    {
        static int hourglassSum(int[][] arr)
        {
            int retVal = int.MinValue;
            int highest = 0;
            for (int i = 0; i < arr.Length - 2; i++)
            {
                for (int j = 0; j < arr.Length - 2; j++)
                {
                    highest = arr[i][j] + arr[i][j + 1] + arr[i][j + 2] + arr[i + 1][j + 1] + arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];
                    if (highest > retVal)
                    {
                        retVal = highest;
                    }
                }
            }

            return retVal;

        }
        static void Main(string[] args)
        {
            int[][] arr = new int[6][];

            string[] arrs = {"-1 -1 0 -9 -2 -2",
                            "-2 -1 -6 -8 -2 -5",
                            "-1 -1 -1 -2 -3 -4",
                            "-1 -9 -2 -4 -4 -5",
                            "-7 -3 -3 -2 -9 -9",
                            "-1 -3 -1 -2 -4 -5" };

            for (int i = 0; i < 6; i++)
            {
                arr[i] = Array.ConvertAll(arrs[i].Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }



            int result = hourglassSum(arr);
            Console.Write("result: " + result.ToString());
            Console.ReadLine();
        }
    }
}
