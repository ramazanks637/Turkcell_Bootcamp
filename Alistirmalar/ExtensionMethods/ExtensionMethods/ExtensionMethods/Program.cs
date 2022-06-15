using ExtensionMethods.Extansions;
using System;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();


            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(random.NextLetter());
                Console.WriteLine(random.NextWord(5));
            }



        }
    }
}
