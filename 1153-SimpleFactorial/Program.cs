// Leia um número N (0<N<13) e retorne o cálculo de seu fatorial

using System;

namespace SimpleFactorial;

public class Program {
    public static void Main(){

        Console.Write("Digite um número: ");
        int input = int.Parse(Console.ReadLine());
        int fatorial = 1;

        for(int i=input; i>0; i--) {
            fatorial *= i;
        }

        Console.WriteLine(fatorial);

    }
}