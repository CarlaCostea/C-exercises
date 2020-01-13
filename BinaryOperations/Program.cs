using System;

namespace BinaryOperations
{
    public class Program
    {
        public const string Error = "Nu s-a introdus un numar binar valid (format doar din 0 si 1).";
        public const string False = "False";
        private const string OperationCodeConvertDecimal = "1";
        private const string OperationCodeConvertBinary = "2";
        private const string OperationCodeNOT = "3";
        private const string OperationCodeOR = "4";
        private const string OperationCodeAnd = "5";
        private const string OperationCodeXor = "6";
        private const string OperationCodeShiftLeft = "7";
        private const string OperationCodeShiftRight = "8";
        private const string OperationCodeCompareLessThan = "9";
        private const string OperationCodeCompareGreaterThan = "10";
        private const string OperationCodeEqual = "11";
        private const string OperationCodeNotEqual = "12";
        private const string OperationAdd = "13";
        private const string InvalidOperation = "14";

        public static void Main()
        {
            string operationCode = Console.ReadLine();
            if (!GetValidOperation(operationCode))
            {
                Console.WriteLine("Operatie invalida.");
            }
            else
            {
                ExecuteConversionOperations(operationCode);
                ExecuteLogicalOperations(operationCode);
                ExecuteShiftOperations(operationCode);
                ExecuteComparisonOperations(operationCode);
                ExecuteArithmeticalOperations(operationCode);
            }
        }

        public static string CompareLessThan(string v1, string v2)
        {
            v1 = CutZeroFromBeginning(v1);
            v2 = CutZeroFromBeginning(v2);
            if (v1 == null || v2 == null)
            {
                return False;
            }

            if (!ValidBaseTwoNumber(v1) || !ValidBaseTwoNumber(v2))
            {
                return Error;
            }

            if (v1.Length == v2.Length)
            {
                return LessThan(v1, v2);
            }

            return v1.Length < v2.Length ? "true" : "false";
        }

        public static string OperationShiftRight(string v)
        {
            string input = Console.ReadLine();
            if (!GetValid(input))
            {
                return "Numarul de pozitii trebuie sa fie intreg si pozitiv.";
            }

            int numberToExecute = Convert.ToInt32(input);
            if (v == null || numberToExecute >= v.Length)
            {
                return "0";
            }

            if (!ValidBaseTwoNumber(v))
            {
                return Error;
            }

            while (numberToExecute != 0)
            {
                v = v.Remove(v.Length - 1);
                numberToExecute--;
            }

            return v;
        }

        public static string OperationShiftLeft(string v)
        {
            string input = Console.ReadLine();
            if (!GetValid(input))
            {
                return "Numarul de pozitii trebuie sa fie intreg si pozitiv.";
            }

            if (!ValidBaseTwoNumber(v))
            {
                return Error;
            }

            int numberToExecute = Convert.ToInt32(input);
            string result = v;
            while (numberToExecute != 0)
            {
                result += '0';
                numberToExecute--;
            }

            return result;
        }

        public static string OperationXOR(string number1, string number2)
        {
            return LogicalOperation(number1, number2, OperationCodeXor);
        }

        public static string OperationOR(string number1, string number2)
        {
            return LogicalOperation(number1, number2, OperationCodeOR);
        }

        public static string OperationAND(string number1, string number2)
        {
            return LogicalOperation(number1, number2, OperationCodeAnd);
        }

        public static string LogicalOperation(string number1, string number2, string operationCode)
        {
            if (number1 == null || number2 == null)
            {
                return "0";
            }

            if (!ValidBaseTwoNumber(number1) || !ValidBaseTwoNumber(number2))
            {
                return Error;
            }

            ArrangeBinaryNumbers(ref number1, ref number2);
            string result = "";
            for (int i = 0; i < number1.Length; i++)
            {
                result += GetLogicalResult(number2[i], number1[i], operationCode);
            }

            return CutZeroFromBeginning(result);
        }

        public static string OperationNOT(string numberToChange)
        {
            string solution = "";
            if (numberToChange == null || !ValidBaseTwoNumber(numberToChange))
            {
                return Error;
            }

            foreach (var c in numberToChange)
            {
                solution = c == '0' ? solution + '1' : solution + '0';
            }

            return CutZeroFromBeginning(solution);
        }

        public static string CutZeroFromBeginning(string solution)
        {
            if (solution == null)
            {
                return "0";
            }

            string result = "";
            int zeroes = 0;
            while (solution[zeroes] != '1' && zeroes < solution.Length - 1)
            {
                zeroes++;
            }

            if (zeroes == solution.Length)
            {
                return "0";
            }

            for (int i = zeroes; i < solution.Length; i++)
            {
                result += solution[i];
            }

            return result;
        }

        public static string ConvertBaseTwoToDecimal(string numberToChange)
        {
            const int baseToConvert = 2;
            return ValidBaseTwoNumber(numberToChange)
                ? Convert.ToString(Convert.ToInt64(numberToChange, baseToConvert))
                : "Nu s-a introdus un numar binar valid (format doar din 0 si 1).";
        }

        public static bool ValidBaseTwoNumber(string numberToChange)
        {
            if (numberToChange == null)
            {
                return false;
            }

            foreach (var c in numberToChange)
            {
                if (c != '0' && c != '1')
                {
                    return false;
                }
            }

            return true;
        }

        public static bool GetValid(string numberToChange)
        {
            int number;
            return int.TryParse(numberToChange, out number) && number >= 0;
        }

        public static bool GetValidOperation(string numberToChange)
        {
            int number;
            return int.TryParse(numberToChange, out number) && number > 0 && number < Convert.ToInt32(InvalidOperation);
        }

        public static string ConvertDecimalToBaseTwo(string numberToChange)
        {
            const int baseToConvert = 2;
            return GetValid(numberToChange) ? Convert.ToString(Convert.ToInt32(numberToChange), baseToConvert) : "Programul converteste doar numere intregi pozitive.";
        }

        public static string FromBinaryString(string binary)
        {
            const int baseToConvert = 2;
            if (!ValidBaseTwoNumber(binary) || binary == null)
            {
                return "Nu s-a introdus un numar binar valid (format doar din 0 si 1).";
            }

            decimal result = 0;
            foreach (var c in binary)
            {
                result *= baseToConvert;
                result += c - '0';
            }

            return Convert.ToString(result);
        }

        public static string NotEqual(string v1, string v2)
        {
            if (Equal(v1, v2) == False)
            {
                return "true";
            }

            return False;
        }

        public static string Equal(string v1, string v2)
        {
            v1 = CutZeroFromBeginning(v1);
            v2 = CutZeroFromBeginning(v2);
            if (v1 == null || v2 == null)
            {
                return False;
            }

            if (!ValidBaseTwoNumber(v1) || !ValidBaseTwoNumber(v2))
            {
                return Error;
            }

            if (v1.Length != v2.Length)
            {
                return False;
            }

            for (int i = 0; i < v1.Length; i++)
            {
                if (v1[i] != v2[i])
                {
                    return False;
                }
            }

            return "true";
        }

        public static string ArithmeticalOperations(string v1, string v2)
        {
            if (v1 == null || v2 == null)
            {
                return "0";
            }

            if (!ValidBaseTwoNumber(v1) || !ValidBaseTwoNumber(v2))
            {
                return Error;
            }

            ArrangeBinaryNumbers(ref v1, ref v2);
            string result = "";
            int carry = 0;
            for (int i = v1.Length - 1; i >= 0; i--)
            {
                result += Add(v1[i], v2[i], ref carry);
            }

            if (carry == 1)
            {
                result += 1;
            }

            return CutZeroFromBeginning(ReverseString(ref result));
        }

        private static string ReverseString(ref string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        private static string Add(char v1, char v2, ref int carry)
        {
            const int sumMax = 2;
            if ((v1 - '0') + (v2 - '0') + carry == 0)
            {
                carry = 0;
                return "0";
            }

            if ((v1 - '0') + (v2 - '0') + carry == sumMax)
            {
                carry = 1;
                return "0";
            }

            if ((v1 - '0') + (v2 - '0') + carry > sumMax)
            {
                carry = 1;
                return "1";
            }

            carry = 0;
            return "1";
        }

        private static string Max(string number1, string number2)
        {
            return number1.Length < number2.Length ? number2 : number1;
        }

        private static string Min(string number1, string number2)
        {
            return number1.Length < number2.Length ? number1 : number2;
        }

        private static string MakeThemEqual(string biggerNumber, string smallerNumber)
        {
            while (smallerNumber.Length != biggerNumber.Length)
            {
                smallerNumber = "0" + smallerNumber;
            }

            return smallerNumber;
        }

        private static void ArrangeBinaryNumbers(ref string number1, ref string number2)
        {
            if (number1 == null || number2 == null)
            {
                return;
            }

            string biggerNumber;
            if (number1.Length == number2.Length)
            {
                return;
            }

            biggerNumber = Max(number1, number2);
            string smallerNumber = Min(number1, number2);
            number2 = MakeThemEqual(biggerNumber, smallerNumber);
            number1 = biggerNumber;
        }

        private static char GetLogicalResult(char v1, char v2, string operationCode)
        {
            switch (operationCode)
            {
                case OperationCodeAnd:
                    return v1 == '1' && v2 == '1' ? '1' : '0';
                case OperationCodeOR:
                    return v1 == '1' || v2 == '1' ? '1' : '0';
                case OperationCodeXor:
                    return (v1 - '0') + (v2 - '0') == 1 ? '1' : '0';
                default:
                    return '\0';
            }
        }

        private static string LessThan(string v1, string v2)
        {
            for (int i = 0; i < v1.Length; i++)
            {
                if (v1[i] == '1' && v2[i] == '0')
                {
                    return False;
                }

                if (v2[i] == '1' && v1[i] == '0')
                {
                    return "true";
                }
            }

            return False;
        }

        private static void ExecuteComparisonOperations(string operationCode)
        {
            switch (operationCode)
            {
                case OperationCodeCompareLessThan:
                    Console.WriteLine(CompareLessThan(Console.ReadLine(), Console.ReadLine()));
                    return;
                case OperationCodeCompareGreaterThan:
                    CompareGreaterThan(Console.ReadLine(), Console.ReadLine());
                    return;
                case OperationCodeEqual:
                    Console.WriteLine(Equal(Console.ReadLine(), Console.ReadLine()));
                    return;
                case OperationCodeNotEqual:
                    Console.WriteLine(NotEqual(Console.ReadLine(), Console.ReadLine()));
                    return;
                default:
                    return;
            }
        }

        private static void CompareGreaterThan(string v1, string v2)
        {
            Console.WriteLine(CompareLessThan(v2, v1));
        }

        private static void ExecuteShiftOperations(string operationCode)
        {
            switch (operationCode)
            {
                case OperationCodeShiftLeft:
                    Console.WriteLine(OperationShiftLeft(Console.ReadLine()));
                    return;
                case OperationCodeShiftRight:
                    Console.WriteLine(OperationShiftRight(Console.ReadLine()));
                    return;
                default:
                    return;
            }
        }

        private static void ExecuteLogicalOperations(string operationCode)
        {
            switch (operationCode)
            {
                case OperationCodeAnd:
                case OperationCodeOR:
                case OperationCodeXor:
                    Console.WriteLine(LogicalOperation(Console.ReadLine(), Console.ReadLine(), operationCode));
                    return;
                case OperationCodeNOT:
                    Console.WriteLine(OperationNOT(Console.ReadLine()));
                    return;
                default:
                    return;
            }
        }

        private static void ExecuteConversionOperations(string operationCode)
        {
            switch (operationCode)
            {
                case OperationCodeConvertDecimal:
                    Console.WriteLine(ConvertDecimalToBaseTwo(Console.ReadLine()));
                    return;
                case OperationCodeConvertBinary:
                    Console.WriteLine(ConvertBaseTwoToDecimal(Console.ReadLine()));
                    return;
                default:
                    return;
            }
        }

        private static void ExecuteArithmeticalOperations(string operationCode)
            {
            if (operationCode != OperationAdd)
            {
                return;
            }

            Console.WriteLine(ArithmeticalOperations(Console.ReadLine(), Console.ReadLine()));
        }
    }
}
