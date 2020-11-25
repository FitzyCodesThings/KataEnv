using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace KataEnv
{
    public static class Kata
    {
        public static List<string> Anagrams(string word, List<string> words)
        {
            List<string> anagrams = new List<string>();

            foreach (var item in words)
            {
                if (item.Length == word.Length)
                {
                    if (item
                        .Select(c => c)
                        .OrderBy(o => o)                        
                            .SequenceEqual(
                                word
                                    .Select(c => c)
                                    .OrderBy(o => o)                                    
                            )
                    )
                        anagrams.Add(item);
                }
            }

            return anagrams;                        
        }
    }
}
