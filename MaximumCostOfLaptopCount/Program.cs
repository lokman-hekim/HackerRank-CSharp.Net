using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumCostOfLaptopCount
{
    public class Result
    {

        /*
         * Complete the 'maxCost' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER_ARRAY cost
         *  2. STRING_ARRAY labels
         *  3. INTEGER dailyCount
         */

        public static int maxCost(List<int> cost, List<string> labels, int dailyCount)
        {
            int maxCost = 0;
            int reachedDailyCount = 0;
            int dailyCost = 0;
            int[] arrCost = cost.ToArray();
            string[] arrLabels = labels.ToArray();
            for (int i = 0; i < arrCost.Length; i++)
            {
                if (arrLabels[i] == "legal")
                {
                    dailyCost += arrCost[i];
                    reachedDailyCount++;
                }
                else
                {
                    dailyCost += arrCost[i];
                }

                if(reachedDailyCount == dailyCount)
                {
                    if (dailyCost > maxCost)
                    {
                        maxCost = dailyCost;
                    }
                    reachedDailyCount = 0;
                    dailyCost = 0;
                }
                

            }


            return maxCost;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {


            int costCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> cost = new List<int>();

            for (int i = 0; i < costCount; i++)
            {
                int costItem = Convert.ToInt32(Console.ReadLine().Trim());
                cost.Add(costItem);
            }

            int labelsCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> labels = new List<string>();

            for (int i = 0; i < labelsCount; i++)
            {
                string labelsItem = Console.ReadLine();
                labels.Add(labelsItem);
            }

            int dailyCount = Convert.ToInt32(Console.ReadLine().Trim());

            int result = Result.maxCost(cost, labels, dailyCount);

            Console.Write(result);
            Console.ReadLine();

        }
    }
}
