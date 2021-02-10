using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfThrones
{
    public class Program
    {
        static void Main(string[] args)
        {
            string s = "cdcdcdcdeeeef";

            string result = gameOfThrones(s);

            Console.WriteLine(result);
            Console.ReadLine();

        }

        public static string gameOfThrones(string s)
        {
            string retVal = "YES";

            Dictionary<char, int> counts = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
                if (counts.ContainsKey(s[i]))
                    counts[s[i]]++;
                else
                    counts.Add(s[i], 1);

            bool isOdd = false;
            foreach (KeyValuePair<char, int> item in counts)
            {
                if (item.Value % 2 != 0)
                {
                    if (isOdd == false)
                    {
                        isOdd = true;
                    }
                    else
                    {
                        retVal = "NO";
                        break;
                    }
                }
            }


            return retVal;

        }
    }
}
