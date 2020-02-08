using System;
using Xunit;

namespace CorrectPassword.tests
{
    public class TestProgram
    {
        [Fact]
        public void SringWithFiveSmallLettersShouldReturnFive()
        {
            string word = "tests";
            Assert.Equal(5 , Program.CountSmallLetters(word));
        }
        [Fact]
        public void SringWithZeroSmallLettersShouldReturnZero()
        {
            string word = "1234";
            Assert.Equal(0, Program.CountSmallLetters(word));
        }
        [Fact]
        public void SringWithFiveBigLettersShouldReturnFive()
        {
            string word = "TESTS";
            Assert.Equal(5, Program.CountBigLetters(word));
        }
        [Fact]
        public void SringWithZeroBigLettersShouldReturnZero()
        {
            string word = "1234";
            Assert.Equal(0, Program.CountSmallLetters(word));
        }
        [Fact]
        public void SringWithFiveNumbersShouldReturnFive()
        {
            string word = "12345";
            Assert.Equal(5, Program.CountNumbers(word));
        }
        [Fact]
        public void SringWithZeroNumbersShouldReturnZero()
        {
            string word = "asdsdf";
            Assert.Equal(0, Program.CountNumbers(word));
        }
            [Fact]
        public void SringWithFiveSymbolsShouldReturnFive()
        {
            string word = "=====";
            Assert.Equal(5, Program.CountSymbols(word));
        }
        [Fact]
        public void SringWithZeroSymbolsShouldReturnZero()
        {
            string word = "asdsdf";
            Assert.Equal(0, Program.CountSymbols(word));
        }
        [Fact]
        public void SringWithSimilarsShouldReturnTrue()
        {
            string word = "iiI1";
            string[] similars = "l,1,I,o,0,O".Split(',');
            Assert.Equal(true, Program.SearchSimilars(word, similars));
        }
        [Fact]
        public void SringWithoutSimilarsShouldReturnFalse()
        {
            string word = "asdsdf";
            string[] similars = "l,1,I,o,0,O".Split(',');
            Assert.Equal(false, Program.SearchSimilars(word, similars));
        }
        [Fact]
        public void SringWithAmbiguousShouldReturnTrue()
        {
            string word = "{iI1";
            string[] ambiguous = "{ } [ ] ( ) / \\ \' \" ~ , ; . < >".Split(' ');
            Assert.Equal(true, Program.SearchAmbiguous(word, ambiguous));
        }
        [Fact]
        public void SringWithoutambiguousShouldReturnFalse()
        {
            string word = "asdsdf";
            string[] ambiguous = "{ } [ ] ( ) / \\ \' \" ~ , ; . < >".Split(' ');
            Assert.Equal(false, Program.SearchAmbiguous(word, ambiguous));
        }
    }
}
