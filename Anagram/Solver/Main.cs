using Anagram.Solver;
using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace Anagram
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Anagram Solver!");
            Console.WriteLine("Enter a word: ");
            string word = Console.ReadLine();
            WordList wordList = new WordList(word);
        }
    }
}
