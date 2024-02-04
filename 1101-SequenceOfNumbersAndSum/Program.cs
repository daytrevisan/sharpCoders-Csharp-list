// Leia um par de números (M e N), retorne em ordem crescente esses números (incluindo M e N) e sua respectiva soma
// O programa deve encerrar quando um deles for igual ou menor que zero 

using System;
class URI {
    static void Main(string[] args) { 
        while (true) {
            string[] input = Console.ReadLine().Split();
            int M = int.Parse(input[0]);
            int N = int.Parse(input[1]);

            if (M <= 0 || N <= 0)
                break;

            int min = Math.Min(M, N);
            int max = Math.Max(M, N);

            PrintSequenceAndSum(min, max);
        }
    }

    static void PrintSequenceAndSum(int min, int max) {
        int sum = 0;

        for (int i = min; i <= max; i++) {
            Console.Write(i + " ");
            sum += i;
        }

        // Imprime a soma no final
        Console.WriteLine("Sum=" + sum);
    }
    
}