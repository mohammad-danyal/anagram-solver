using Anagram.Solver;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq.Expressions;

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
                var word = Console.ReadLine();

                var serviceProvider = new ServiceCollection()
                    .AddTransient<IInputValidater, InputValidater>()
                    .AddTransient<IAnagramSolver, AnagramSolver>()
                    .AddTransient<IWordList, WordList>()
                    .AddScoped<IPairCalculator, PairCalculator>()

                    .BuildServiceProvider();

                var inputvalidate = serviceProvider.GetService<IInputValidater>(); //

                if (inputvalidate.IsInputValid(word)) {

                    var solver = serviceProvider.GetService<IAnagramSolver>();
                    var pairs = solver.FindAnagrams(word); //

                    foreach (var pair in pairs)
                    {
                        Console.WriteLine(pair.combinedWord); //
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
