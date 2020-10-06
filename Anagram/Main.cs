using Anagram.Solver;
using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace Anagram
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Anagram Solver!");


            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine("Enter a word: ");
                string word = Console.ReadLine();

                InputValidater inputvalidate = new InputValidater();

                if (inputvalidate.IsInputValid(word)) {
  
                    var pairs = AnagramSolver.FindAnagrams(word);

                    foreach (Pair pair in pairs)
                    {
                        Console.WriteLine(pair.firstWord + " " + pair.secondWord);
                    }

                    if (pairs.Count == 0)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("No anagrams are possible for your word");
                    }

                } else
                {
                    Console.WriteLine("Error: Input is not a valid word");
                }

            }

        }
    }
}
