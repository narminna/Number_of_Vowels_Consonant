using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vowel = 0;
            int consonant = 0;
            Console.WriteLine("Input :");
            string input = Console.ReadLine();
            string lowerstr = input.ToLower();
            for (int i = 0; i < lowerstr.Length; i++)
            {
                if (char.IsLetter(lowerstr[i]))
                {
                    if (lowerstr[i] == 'a' || lowerstr[i] == 'e' || lowerstr[i] == 'i' || lowerstr[i] == 'o' || lowerstr[i] == 'u')
                    {
                        vowel++;
                    }

                    else
                    {
                        consonant++;
                    }
                }
            }
            Console.WriteLine($"Number of vowels {vowel}, number of consonant {consonant}");

        }
    }
}
