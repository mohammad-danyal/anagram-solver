using System;
using Anagram;
using Anagram.Solver;
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

            Assert.True(pair.firstWord == wordOne);
            Assert.True(pair.secondWord == wordTwo);
        }

    }

}