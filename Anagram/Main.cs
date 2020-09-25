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

                Console.WriteLine("\nEnter a word: ");
                string word = Console.ReadLine();

                InputValidater inputvalidate = new InputValidater();

                if (inputvalidate.IsInputValid(word)) {

                    WordList possibleWords = new WordList(word);

                    PairCalculator pairCalculator = new PairCalculator(possibleWords.GetWords(), word);
                    pairCalculator.GetPairs(word).ForEach(Console.WriteLine);

                    if (pairCalculator.GetPairs(word).Count == 0)
                    {
                        Console.WriteLine("\nNo anagrams are possible for your word");
                    }

                }

            }

        }
    }
}
