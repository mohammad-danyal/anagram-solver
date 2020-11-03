using Anagram.Solver;
using AnagramSolverAPI.Services;
using FluentAssertions;
using Xunit;

namespace AnagramSolverAPI.Tests1
{
    public class GetWords
    {

        [Fact]
        public void ValidWordsTest()
        {

            string word = "blue";

            WordListWeb possibleWords = new WordListWeb();

            (possibleWords.GetWords(word).Count).Should().BeGreaterThan(0);

        }

        [Fact]
        public void InvalidWordsTest()
        {

            string word = "xxx";

            WordListWeb possibleWords = new WordListWeb();

            (possibleWords.GetWords(word).Count).Should().Be(1);
        }
    }
}
