using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoStrings
{
    public class Program
    {
        static void Main(string[] args)
        {


            string s1 = "hi";

            string s2 = "world";

            string result = twoStrings(s1, s2);

            Console.WriteLine(result);
            Console.Read();
        }

        public static string twoStrings1(string s1, string s2)
        {
            string retVal = "NO";

            char[] arrS1 = s1.ToArray();



            for (int i = 0; i < arrS1.Length; i++)
            {
                if (s2.Contains(arrS1[i]))
                {
                    retVal = "YES";
                    break;
                }
            }
            return retVal;

        }

        public static string twoStrings2(string s1, string s2)
        {
            string retVal = "NO";

            char[] arrS1 = s1.ToArray();

            Dictionary<char, int> sd1 = new Dictionary<char, int>();
            for (int i = 0; i < arrS1.Length; i++)
            {
                if (!sd1.Keys.Contains(arrS1[i]))
                {
                    sd1.Add(arrS1[i], 1);
                }
                if (sd1.Count == 26)
                {
                    break;
                }
            }

            char[] arrS2 = s2.ToArray();

            Dictionary<char, int> sd2 = new Dictionary<char, int>();

            for (int i = 0; i < arrS2.Length; i++)
            {
                if (!sd2.Keys.Contains(arrS2[i]))
                {
                    sd2.Add(arrS2[i], 1);
                }
                if (sd2.Count == 26)
                {
                    break;
                }
            }
            if (sd2.Count == 26 && sd1.Count == 26)
            {
                retVal = "YES";
            }
            else
            {

                foreach (KeyValuePair<char, int> item in sd2)
                {
                    if (sd1.Keys.Contains(item.Key))
                    {
                        retVal = "YES";
                        break;
                    }
                }

            }
            return retVal;

        }

        public static string twoStrings(string s1, string s2)
        {
            string retVal = "NO";

            HashSet<char> c1 = new HashSet<char>(s1);
            HashSet<char> c2 = new HashSet<char>(s2);
         
            if (c1.Count == 26 && c2.Count == 26)
            {
                retVal = "YES";
            }
            else
            {

                foreach (char item in c1)
                {
                    if (c2.Contains(item))
                    {
                        retVal = "YES";
                        break;
                    }
                }

            }
            return retVal;

        }



        public static string twoStrings3(string s1, string s2)
        {
            string retVal;
            int c1 = new HashSet<char>(s1).Count;
            int c2 = new HashSet<char>(s2).Count;

            var set = new HashSet<char>(s1 + s2);
            if (set.Count < c1 + c2) retVal = "YES";
            else retVal = "NO";
            return retVal;
        }


    }
}
