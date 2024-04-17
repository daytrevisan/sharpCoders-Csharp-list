using System;

namespace SimpleSort;

public class Program {
    public static void Main(string[] args) {

        string[] inputs = Console.ReadLine().Split(' ');
        int a = int.Parse(inputs[0]);
        int b = int.Parse(inputs[1]);
        int c = int.Parse(inputs[2]);
        int largest = 0;
        int middle = 0;
        int smallest = 0;
    
        if(a >= b && a >= c) {
            largest = a;
            if(b >= c) {
                middle = b;
                smallest = c;
            } else {
                middle = c;
                smallest = b;
            }

        } else if (b >= a && b >= c) {
            largest = b;
            if(a >= c) {
                middle = a;
                smallest = c;
            } else {
                middle = c;
                smallest = a;
            }

        } else if (c >= a && c >= b) {
            largest = c;
            if(a >= b) {
                middle = a;
                smallest = b;
            } else {
                middle = b;
                smallest = a;
            }
        }

        // string[] inputs = Console.ReadLine().Split(' ');

        // int a = int.Parse(inputs[0]);
        // int b = int.Parse(inputs[1]);
        // int c = int.Parse(inputs[2]);

        // int largest = Math.Max(Math.Max(a, b),c);
        // int smallest = Math.Min(Math.Min(a, b),c);
        // int middle;

        // if(a != largest && a != smallest) {
        //     middle = a;
        // } else if(b != largest && b != smallest) {
        //     middle = b;
        // } else {
        //     middle = c;
        // }

        Console.WriteLine(smallest);
        Console.WriteLine(middle);
        Console.WriteLine(largest);
        Console.WriteLine();
        Console.WriteLine(largest);
        Console.WriteLine(middle);
        Console.WriteLine(smallest);

    }
}