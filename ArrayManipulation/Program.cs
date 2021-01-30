using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManipulation
{
    public class Program
    {
        public static void Main(string[] args)
        {

            int n = 5;
            int[][] queries = new int[3][];
            queries[0] = new int[] { 1, 2, 100 };
            queries[1] = new int[] { 2, 5, 100 };
            queries[2] = new int[] { 3, 4, 100 };


            long result = arrayManipulation(n, queries);

            Console.WriteLine(result);
            Console.ReadLine();
        }
        public static long arrayManipulation(int n, int[][] queries)
        {
            long[] control = new long[n + 1];
            long a, b, k;
            for (int i = 0; i < queries.Length; i++)
            {
                a = queries[i][0];
                b = queries[i][1];
                k = queries[i][2];

                control[a - 1] += k;
                control[b] -= k;
            }

            long max = long.MinValue;
            long sum = 0;
            for (int i = 0; i < control.Length; i++)
            {
                sum += control[i];
                max = Math.Max(max, sum);
            }
            return max;
        }

    }
}
