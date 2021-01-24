using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAnagram
{
    public class Program
    {
        public static List<int> stringAnagram(List<string> dictionary, List<string> query)
        {
            List<int> retvaL = new List<int>();
            int matching = 0;
            foreach (string itemQuery in query)
            {
                foreach (var itemDic in dictionary)
                {
                    if (itemQuery.Length == itemDic.Length)
                    {
                        char[] qc = itemQuery.ToCharArray();
                        bool isAllCharMatch = false;
                        for (int i = 0; i < qc.Length; i++)
                        {
                            isAllCharMatch = itemDic.Contains(qc[i]);
                            if (!isAllCharMatch)
                            {
                                break;
                            }
                        }
                        if (isAllCharMatch)
                        {
                            matching++;
                        }
                    }
                }
                retvaL.Add(matching);
                matching = 0;
            }

            return retvaL;
        }
        static void Main(string[] args)
        {
            int dictionaryCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> dictionary = new List<string>();

            for (int i = 0; i < dictionaryCount; i++)
            {
                string dictionaryItem = Console.ReadLine();
                dictionary.Add(dictionaryItem);
            }

            int queryCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> query = new List<string>();

            for (int i = 0; i < queryCount; i++)
            {
                string queryItem = Console.ReadLine();
                query.Add(queryItem);
            }

            List<int> result = stringAnagram(dictionary, query);

            Console.Write(String.Join("\n", result));
        }
    }
}
