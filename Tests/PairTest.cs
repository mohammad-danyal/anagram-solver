using Anagram.Solver;
using AnagramSolverAPI.Models;
using FluentAssertions;
using Xunit;

namespace PairTest
{
    public class PairTest
    {

        [Theory]
        [InlineData("blue", "red")]
        [InlineData("window", "door")]
        [InlineData("two", "three")]
        public void GetPairTest(string wordOne, string wordTwo)
        {

            var pair = new Pair();

            pair.firstWord = wordOne;
            pair.secondWord = wordTwo;

            (pair.firstWord).Should().Be(wordOne);
            (pair.secondWord).Should().Be(wordTwo);
        }


        [Theory]
        [InlineData("blue", "red", "blue red")]
        [InlineData("window", "door", "window door")]
        [InlineData("two", "three", "two three")]
        public void CombinedWordTest(string wordOne, string wordTwo, string combinedWord)
        {

            var pair = new Pair();

            pair.firstWord = wordOne;
            pair.secondWord = wordTwo;

            (pair.combinedWord).Should().Be(combinedWord);

        }

    }

}