using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash_Tables_Ransom_Note
{
 public   class Program
    {
        public static void Main(string[] args)
        {


            string[] magazine = "two times three is not four".Split(' ');

            string[] note = "two times two is four".Split(' ');

            checkMagazine(magazine, note);
            Console.ReadLine();
        }

        public static string checkMagazine(string[] magazine, string[] note)
        {
            Dictionary<string, int> magWords = new Dictionary<string, int>();
            foreach (string item in magazine)
            {
                if (magWords.Keys.Contains(item))
                {
                    magWords[item]++;
                }
                else
                {
                    magWords.Add(item, 1);
                }
            }

            string msg = "Yes";
            for (int i = 0; i < note.Length; i++)
            {
                if (magWords.Keys.Contains(note[i]))
                {
                    if (magWords[note[i]] > 0)
                    {
                        magWords[note[i]]--;
                    }
                    else
                    {
                        msg = "No";
                        break;
                    }

                }
                else
                {
                    msg = "No";
                    break;
                }
            }
            Console.WriteLine(msg);
            return msg;
        }
    }
}
