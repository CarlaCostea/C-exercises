using System;
using Xunit;

namespace BinaryOperations.Tests
{
    public class TestProgram
    {
        [Fact]
        public void OnePositiveNumberShouldBeConvertetedInBase2()
        {
            string numberToChange = "45";
            Assert.Equal("101101", Program.ConvertDecimalToBaseTwo(numberToChange));
        }
        [Fact]
        public void NotAPositiveNumberShoudTrowAnError()
        {
            string numberToChange = "x";
            Assert.Equal("Programul converteste doar numere intregi pozitive.", Program.ConvertDecimalToBaseTwo(numberToChange));
        }
        [Fact]
        public void OneBinaryNumberShouldBeConvertedInDecimal()
        {
            string numberToChange = "101101";
            Assert.Equal("45", Program.ConvertBaseTwoToDecimal(numberToChange));
        }
        [Fact]
        public void OneEronatedBinaryNumberShouldTrowAnError()
        {
            string numberToChange = "102411";
            Assert.Equal("Nu s-a introdus un numar binar valid (format doar din 0 si 1).", Program.ConvertBaseTwoToDecimal(numberToChange));
        }
        [Fact]
        public void ApplyNOT()
        {
            string numberToChange = "101101";
            Assert.Equal("10010", Program.OperationNOT(numberToChange));
        }
        [Fact]
        public void ApplyNOTForNumbersWithoutZeroes()
        {
            string numberToChange = "111";
            Assert.Equal("0", Program.OperationNOT(numberToChange));
        }
        [Fact]
        public void ApplyORForEqualLengthNumbers()
        {
            string number = "1010";
            string numberToChange = "1100";
            Assert.Equal("1110", Program.OperationOR(numberToChange, number));
        }
        [Fact]
        public void ApplyORForDifferrentLengthNumbers()
        {
            string number = "10100";
            string numberToChange = "111";
            Assert.Equal("10111", Program.OperationOR(numberToChange, number));
        }

        [Fact]
        public void ApplyORForNonBinaryNumbersShoulTrowAnError()
        {
            string number = "10100";
            string numberToChange = "112";
            Assert.Equal("Nu s-a introdus un numar binar valid (format doar din 0 si 1).", Program.OperationOR(numberToChange, number));
        }
        [Fact]
        public void ApplyANDForEqualLengthNumbers()
        {
            string number = "1010";
            string numberToChange = "1100";
            Assert.Equal("1000", Program.OperationAND(numberToChange, number));
        }
        [Fact]
        public void ApplyANDForDifferrentLengthNumbers()
        {
            string number = "10100";
            string numberToChange = "111";
            Assert.Equal("100", Program.OperationAND(numberToChange, number));
        }

        [Fact]
        public void ApplyANDForNonBinaryNumbersShoulTrowAnError()
        {
            string number = "10100";
            string numberToChange = "112";
            Assert.Equal("Nu s-a introdus un numar binar valid (format doar din 0 si 1).", Program.OperationAND(numberToChange, number));
        }
        [Fact]
        public void ApplyXORForEqualLengthNumbers()
        {
            string number = "1010";
            string numberToChange = "1100";
            Assert.Equal("110", Program.OperationXOR(numberToChange, number));
        }
        [Fact]
        public void ApplyXORForDifferrentLengthNumbers()
        {
            string number = "10100";
            string numberToChange = "111";
            Assert.Equal("10011", Program.OperationXOR(numberToChange, number));
        }

        [Fact]
        public void ApplyXORForNonBinaryNumbersShoulTrowAnError()
        {
            string number = "10100";
            string numberToChange = "112";
            Assert.Equal("Nu s-a introdus un numar binar valid (format doar din 0 si 1).", Program.OperationXOR(numberToChange, number));
        }
    }
}
