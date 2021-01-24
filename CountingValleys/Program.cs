using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingValleys
{
    public class Program
    {
        /*
     * Complete the 'countingValleys' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER steps
     *  2. STRING path
     */

        public static int countingValleys(int steps, string path)
        {
            int valley = 0;
            int level = 0;
            char[] arrStep = path.ToCharArray();
            for (int i = 0; i < steps; i++)
            {
                if (arrStep[i].Equals('U')){
                    level += 1;
                }
                else if (arrStep[i].Equals('D'))
                {
                    level -= 1;
                }
                if(level==0 && arrStep[i].Equals('U'))
                {
                    valley++;
                }
            }
            return valley;
        }
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter("c:\\Temprorary\\a.txt", true);

            int steps = Convert.ToInt32(Console.ReadLine().Trim());

            string path = Console.ReadLine();

            int result = countingValleys(steps, path);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
