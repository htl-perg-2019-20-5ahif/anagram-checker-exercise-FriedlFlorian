using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace HUE02_AnagramChecker_Friedl
{
    public class Words
    {
        public String word1 { get; set; }
        public String word2 { get; set; }

        public Words(string word1, string word2)
        {
            this.word1 = word1;
            this.word2 = word2;
        }

        public Boolean CheckAnagram(string word1, string word2)
        {
            if (word1.Length != word2.Length)
            {
                return false;
            }
            var sorted1 = String.Concat(word1.OrderBy(c => c));
            var sorted2 = String.Concat(word2.OrderBy(c => c));
            if (sorted1 != sorted2)
            {
                return false;
            }

            return true;
        }

    }
}

            
            
       
