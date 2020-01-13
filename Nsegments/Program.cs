using System;

namespace Nsegments
{
    class Program
    {
        static void Main()
        {
            int numberSegments = Convert.ToInt32(Console.ReadLine());
            int[,] coordinates = new int[numberSegments + 1, 2];
            coordinates[0, 0] = 0;
            coordinates[0, 1] = 0;
            for (int i = 1; i < numberSegments + 1; i++)
            {
                string direction = Console.ReadLine();
                Move(direction, i, coordinates);
                Move(direction, i, coordinates);
            }

            bool inter = false;
            for (int i = 0; i < numberSegments + 1; i++)
            {
                if (Intersection(i, coordinates))
                {
                    Console.WriteLine("True");
                    inter = true;
                    break;
                }
            }

            if (inter)
            {
                return;
            }

            Console.WriteLine("False");
        }

        static void Move(string where, int i, int[,] coord)
        {
            switch (where)
            {
                case "down":
                    coord[i, 0] = coord[i - 1, 0];
                    coord[i, 1] = coord[i - 1, 1] + 1;
                    break;

                case "up":
                    coord[i, 0] = coord[i - 1, 0];
                    coord[i, 1] = coord[i - 1, 1] - 1;
                    break;
                case "right":
                    coord[i, 0] = coord[i - 1, 0] + 1;
                    coord[i, 1] = coord[i - 1, 1];
                    break;
                case "left":
                    coord[i, 0] = coord[i - 1, 0] - 1;
                    coord[i, 1] = coord[i - 1, 1];
                    break;
                case null:
                    Console.WriteLine("NO DIRECTION");
                    break;
            }
        }

        static bool Intersection(int i, int[,] coord)
        {
            for (int k = 0; k < i; k++)
            {
                if (coord[k, 0] == coord[i, 0] && coord[k, 1] == coord[i, 1])
                {
                    return true;
                }
            }

            return false;
        }
    }
}
