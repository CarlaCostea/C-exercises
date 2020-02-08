using System;

namespace Segments
{
    [Flags]
    enum Colors
    {
        red = 1,
        green = 2,
        blue = 4
    }
    class Program
    {
        static void Main(string[] args)
        {
            Colors availableColors = Colors.red | Colors.green | Colors.blue;
    availableColors = availableColors & ~Colors.red;

    string result = "";

    if ((availableColors & Colors.red) == 0)
        result += Colors.red + " ";

    if ((availableColors & Colors.green) == 0)
        result += Colors.green + " ";

    if ((availableColors & Colors.blue) == 0)
        result += Colors.blue + " ";

    Console.WriteLine(result);
    Console.Read();
        }
    }
}