using System;

namespace Sudoku
{
    class Program
    {
        public static void Main()
        {
            bool valid = true;
            const int dimension = 9;
            const int inc = 3;
            int[,] square = ReadSquare(dimension, ref valid);
            bool validLine = ValidLine(square, dimension);
            bool validColumn = ValidColumn(square, dimension);
            for (int i = 0; i < dimension; i += inc)
            {
                valid = ValidSquare(square, i);
                if (!valid)
                {
                    break;
                }
            }

            if (validColumn && validLine && valid)
                {
                    Console.WriteLine(validColumn);
                }
                else
                {
                    Console.WriteLine("False");
                }
            }

        private static bool ValidSquare(int[,] square, int index)
            {
                const int inc = 3;
                bool valid = true;
                string result = "";
                for (int i = index; i < index + inc; i++)
                {
                    for (int j = 0; j < inc; j++)
                    {
                        if (result.IndexOf(Convert.ToString(square[i, j])) == -1)
                        {
                            result += Convert.ToString(square[i, j]);
                        }
                        else
                        {
                            valid = false;
                        }
                    }
                }

                return valid;
            }

        private static bool ValidColumn(int[,] square, int dimension)
            {
                bool valid = true;
                for (int i = 0; i < dimension; i++)
                {
                    string result = "";
                    for (int j = 0; j < dimension; j++)
                    {
                        if (result.IndexOf(Convert.ToString(square[j, i])) == -1)
                        {
                            result += Convert.ToString(square[j, i]);
                        }
                        else
                        {
                            valid = false;
                        }
                    }
                }

                return valid;
            }

        private static bool ValidLine(int[,] square, int dimension)
            {
                bool valid = true;
                for (int i = 0; i < dimension; i++)
                {
                    string result = "";
                    for (int j = 0; j < dimension; j++)
                    {
                        if (result.IndexOf(Convert.ToString(square[i, j])) == -1)
                        {
                            result += Convert.ToString(square[i, j]);
                        }
                        else
                        {
                            valid = false;
                        }
                    }
                }

                return valid;
            }

        private static int[,] ReadSquare(int dimension, ref bool valid)
            {
                int[,] result = new int[dimension, dimension];
                for (int i = 0; i < dimension; i++)
                {
                    string input = Console.ReadLine();
                    while (input == "")
                    {
                        input = Console.ReadLine();
                    }

                    while (input.Contains("  "))
                    {
                        input = input.Replace("  ", " ");
                    }

                    string[] line = input.Split(' ');
                    if (line.Length != dimension)
                    {
                        valid = false;
                        break;
                    }

                    for (int j = 0; j < dimension; j++)
                    {
                        if (!int.TryParse(line[j], out result[i, j]) || result[i, j] < 1 || result[i, j] > dimension)
                        {
                            valid = false;
                            break;
                        }

                        result[i, j] = Convert.ToInt32(line[j]);
                    }
                }

                return result;
            }
        }
    }