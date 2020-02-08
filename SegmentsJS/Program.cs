using System;

namespace Segments
{
    enum Move
    {
        Left,
        Right,
        Up,
        Down
    }

    struct Point
    {
        public double X;
        public double Y;

        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }
    }

    class Program
    {
        static void Main()
        {
            Move[] moves = ReadMoves();
            Point[] route = new Point[moves.Length + 1];
            route[0] = new Point(0, 0);

            for (int i = 0; i < moves.Length; i++)
            {
                route[i + 1] = MoveNext(route[i], moves[i]);
            }

            Console.WriteLine(CheckIntersections(route));
            Console.Read();
        }

        static bool CheckIntersections(Point[] route)
        {
            for (int i = 0; i < route.Length - 1; i++)
            {
                for (int j = i + 1; j < route.Length; j++)
                {
                    if (ArePointsEqual(route[i], route[j]))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        static bool ArePointsEqual(Point a, Point b, double precision = 0.001)
        {
            return Math.Abs(a.X - b.X) < precision && Math.Abs(a.Y - b.Y) < precision;
        }

        private static Point MoveNext(Point point, Move move)
        {
            // TO DO:  comment the line below and implement this function
            switch (move)
            {
                case Move.Left:
                    return MoveLeft(point);
                case Move.Right:
                    return MoveRight(point);
                case Move.Up:
                    return MoveUp(point);
                case Move.Down:
                    return MoveDown(ref point);
                default:
                    return point;
            }
        }

        private static Point MoveDown(ref Point point)
        {
          point.Y--;
          return point;
        }

        private static Point MoveUp(Point point)
        {
            point.Y++;
            return point;
        }

        private static Point MoveRight(Point point)
        {
            point.X++;
            return point;
        }

        private static Point MoveLeft(Point point)
        {
            point.X--;
            return point;
        }

        static Move[] ReadMoves()
        {
            string[] movesList = Console.ReadLine().Split(' ');
            Move[] result = new Move[movesList.Length];

            for (int i = 0; i < movesList.Length; i++)
            {
                result[i] = (Move)Convert.ToInt32(movesList[i]);
            }

            return result;
        }
    }
}
