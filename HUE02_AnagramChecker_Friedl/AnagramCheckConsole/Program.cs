using HUE02_AnagramChecker_Friedl;
using System;

namespace AnagramCheckConsole
{
    
    class Program
    {
        static string Main(string[] args)
        {
            string word1 = args[0];
            string word2 = args[1];

            Words words = new Words(word1, word2);

            bool check = words.CheckAnagram(word1, word2);

            if (check)
            {
                return word1 + " and " + word2 + " are an anagram";
            }
            return word1 + " and " + word2 + " are not an anagram";
        }
    }
}
