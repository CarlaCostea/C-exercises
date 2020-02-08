using System;
using Xunit;

namespace PrefixPocketCalculator.tests
{
    public class ProgramTest
    {
        [Fact]
        public void OneOperatorAnd2Numbers()
        {
            string[] inputRequest = "* 3 4".Split(" ");
            decimal resultNumber = 0;
            Assert.Equal(12, Program.MathTranslate(inputRequest, ref resultNumber));
        }
    }
}
