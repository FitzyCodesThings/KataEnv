using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace KataEnv
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
                //"+" + String.Join("",

                    Regex
                        .Replace(
                            "The quick brown fox jumps over the lazy dog.",
                            "[^a-z]",
                            ""
                        )                     
                        .ToLower()                        
                        .Select(c => c)
                        .OrderBy(o => o)                        
                        .ToArray()
                        .Distinct()
                        .Count()
                //)     
                //+ "+"
            );
        }
    }
}
