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
  
                    AnagramSolver.FindAnagrams(word);
                   
                } else
                {
                    Console.WriteLine("Error: Input is not a valid word");
                }

            }

        }
    }
}
