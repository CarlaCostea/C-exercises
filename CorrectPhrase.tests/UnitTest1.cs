using System;
using Xunit;

namespace CorrectPhrase.tests
{
    public class TestProgram
    {       [Fact]
        public void OneValidWordShouldReturnTextCorrect()
        {
            string[] word = { "test" };
            string[] validWords = { "test" };
            Assert.Equal("Text corect!", Program.GetTextAutoCorrectSuggestions(word, validWords));
        }
        [Fact]
        public void OneValidPhraseShouldReturnTextCorrect()
        {
            string[] word = { "ana", "are", "mere" };
            string[] validWords = { "ana", "are", "mere" };
            Assert.Equal("Text corect!", Program.GetTextAutoCorrectSuggestions(word, validWords));
        }
        [Fact]
        public void OneInvalidWordWithhoutSuggestionsShouldReturnNoSuggestions()
        {
            string[] word = { "mere" };
            string[] validWords = { "test" };
            Assert.Equal("mere: (nu sunt sugestii)\n", Program.GetTextAutoCorrectSuggestions(word, validWords));
        }
        [Fact]
        public void OneInvalidWordWithOneWrongLetterShouldReturnSuggestions()
        {
            string[] word = { "mere" };
            string[] validWords = { "mare" };
            Assert.Equal("mere: mare\n", Program.GetTextAutoCorrectSuggestions(word, validWords));
        }
        [Fact]
        public void OneInvalidWordWithOneMoreLetterShouldReturnSuggestions()
        {
            string[] word = { "mere" };
            string[] validWords = { "ere" };
            Assert.Equal("mere: ere\n", Program.GetTextAutoCorrectSuggestions(word, validWords));
        }
        [Fact]
        public void OneInvalidWordWithOneLessLetterShouldReturnSuggestions()
        {
            string[] word = { "mere" };
            string[] validWords = { "merge" };
            Assert.Equal("mere: merge\n", Program.GetTextAutoCorrectSuggestions(word, validWords));
        }

        [Fact]
        public void PhraseWithValidAndInvalidWordsWithAndWithoutSuggestionsShouldReturnRightSuggestions()
        {
            string[] word = { "Ana", "are", "mere", "malte" };
            string[] validWords = { "are", "cere", "pere", "merge", "multe" };
            Assert.Equal("Ana: (nu sunt sugestii)\nmere: cere pere merge\nmalte: multe\n", Program.GetTextAutoCorrectSuggestions(word, validWords));
        }

        [Fact]
        public void OneInvalidWordWithTwoLettersSwapShouldReturnSuggestions()
        {
            string[] word = { "acetsa" };
            string[] validWords = { "acesta" };
            Assert.Equal("acetsa: acesta\n", Program.GetTextAutoCorrectSuggestions(word, validWords));
        }

        [Fact]
        public void PhraseWithValidAndInvalidWordsWithAndWithoutSuggestionsShouldReturnRightSuggestionsAllCases()
        {
            string[] word = { "acetsa", "Ana", "are", "mere", "malte" };
            string[] validWords = { "acesta", "are", "cere", "pere", "merge", "multe" };
            Assert.Equal("acetsa: acesta\nAna: (nu sunt sugestii)\nmere: cere pere merge\nmalte: multe\n", Program.GetTextAutoCorrectSuggestions(word, validWords));
        }
    }
}