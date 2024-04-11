using System;

namespace DistanceBetweenTwoPoints;

public static class Program {

    public static void Main() {
        
    string[] inputs = Console.ReadLine().Split(' ');
    double x1 = double.Parse(inputs[0]);
    double y1 = double.Parse(inputs[1]);

    inputs = Console.ReadLine().Split(' ');
    double x2 = double.Parse(inputs[0]);
    double y2 = double.Parse(inputs[1]);

    double distance_x = Math.Pow(x1-x2,2);
    double distance_y = Math.Pow(y1-y2,2);

    double distance = Math.Sqrt(distance_x + distance_y);

    Console.WriteLine($"{distance:F4}");

    }
}