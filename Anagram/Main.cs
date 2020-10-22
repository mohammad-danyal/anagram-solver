using Anagram.Solver;
using CommandLine;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Anagram
{

    class Program
    {

        class Options
        {
            [Option('w', "web", Required = false, HelpText = "Web Source implemenatation")]
            public bool WebSource { get; set; }

            [Option('n', "nonweb", Required = false, HelpText = "Non Web Source implemenatation")]
            public bool NonWebSource { get; set; }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Anagram Solver!");

            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine("Enter a word: ");
                var word = Console.ReadLine();

                var serviceCollection = new ServiceCollection()
                           .AddTransient<IInputValidater, InputValidater>()
                           .AddTransient<IAnagramSolver, AnagramSolver>()
                           .AddScoped<IPairCalculator, PairCalculator>();

                Parser.Default.ParseArguments<Options>(args).WithParsed<Options>(o =>
                {
                    if (o.WebSource)
                    {
                        serviceCollection.AddTransient<IWordList, WordListWeb>();

                    }
                    else 
                    {
                        serviceCollection.AddTransient<IWordList, WordListNonWeb>();
                  
                    }
                });

                var inputvalidate = serviceCollection.BuildServiceProvider().GetService<IInputValidater>(); //

                if (inputvalidate.IsInputValid(word))
                {

                    var solver = serviceCollection.BuildServiceProvider().GetService<IAnagramSolver>();
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

                }
                else
                {
                    Console.WriteLine("Error: Input is not a valid word");
                }

            }

        }
    }
}
