using System;

namespace PositivesAndAverage;

public class Program {
    public static void Main() {

        int count = 0;
        double sum = 0;

        for(int _ = 0 ; _ < 6; _++) {
            double value = double.Parse(Console.ReadLine());

            if(value > 0) {
                sum += value;
                count++;
            }
        }

        double average = sum / count;

        Console.WriteLine($"{count} valores positivos");
        Console.WriteLine($"{average:F1}");
    }
    
}