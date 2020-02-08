using System;

namespace QuadrilateralPerimeter
{
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

    struct Quadrilateral
    {
        public Point A;
        public Point B;
        public Point C;
        public Point D;

        public Quadrilateral(Point a, Point b, Point c, Point d)
        {
            this.A = a;
            this.B = b;
            this.C = c;
            this.D = d;
        }
    }

    class Program
    {
        static void Main()
        {
            Quadrilateral quadrilateral = new Quadrilateral(ReadPoint(), ReadPoint(), ReadPoint(), ReadPoint());
            Console.WriteLine(CalculatePerimeter(quadrilateral));
            Console.Read();
        }

        static double CalculatePerimeter(Quadrilateral quadrilateral)
        {
            double side1 = Math.Sqrt(Math.Pow(quadrilateral.B.X - quadrilateral.A.X, 2) + Math.Pow(quadrilateral.B.Y - quadrilateral.A.Y, 2));
            double side2 = Math.Sqrt(Math.Pow(quadrilateral.C.X - quadrilateral.B.X, 2) + Math.Pow(quadrilateral.C.Y - quadrilateral.B.Y, 2));
            double side3 = Math.Sqrt(Math.Pow(quadrilateral.D.X - quadrilateral.C.X, 2) + Math.Pow(quadrilateral.D.Y - quadrilateral.C.Y, 2));
            double side4 = Math.Sqrt(Math.Pow(quadrilateral.A.X - quadrilateral.D.X, 2) + Math.Pow(quadrilateral.A.Y - quadrilateral.D.Y, 2));
            return side1 + side2 + side3 + side4;
        }

        static Point ReadPoint()
        {
            string[] point = Console.ReadLine().Split(' ');
            return new Point(Convert.ToDouble(point[0]), Convert.ToDouble(point[1]));
        }
    }
}
