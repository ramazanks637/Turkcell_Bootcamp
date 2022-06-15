using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods.Extansions
{
    public static class MyExtension
    {

        public static char NextLetter(this Random random)
        {
            return (char)random.Next(65, 90);
        }


        public static string NextWord(this Random random,int length)
        {
            string word = string.Empty;
            while (word.Length != length)
            {
                word += random.NextLetter().ToString();
            }

            return word;
        }


        public static string NextWord(this Random random, params string[] words)
        {
            return words[random.Next(0, words.Length)];
        }




    }
}
