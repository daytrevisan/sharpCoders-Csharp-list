using System;

namespace PrimeNumber;
public class Program
{
    public static void Main()
    {

        int teste = int.Parse(Console.ReadLine());

        for (int i = 0; i < teste; i++)
        {
            int X = int.Parse(Console.ReadLine());

            if (IsPrime(X))
                Console.WriteLine($"{X} eh primo");
            else
                Console.WriteLine($"{X} nao eh primo");
        }
    }

    static bool IsPrime(int num)
    {
        if (num <= 1) { return false; }

        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0) { return false; }
        }
        return true;

    }
}