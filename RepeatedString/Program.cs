using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatedString
{
    public class Program
    {
        public static long repeatedString(string s, long n)
        {
            long retVal = 0;

            StringBuilder sb = new StringBuilder();
            long repeat_count = (n / (long)s.Length) ;
            long remainder = n % (long)s.Length;
            long reOccurA= s.Count(f => f == 'a');
            retVal = reOccurA * repeat_count;

            reOccurA= s.Substring(0,(int)remainder).Count(f => f == 'a');
            retVal += reOccurA;
            return retVal;

        }
        static void Main(string[] args)
        {
            long n = 1000000000000;
            //-------1000000000000
            string s = "a";

            long result = repeatedString(s, n);
            Console.Write("result: " + result.ToString());
            Console.ReadLine();
        }
    }
}
