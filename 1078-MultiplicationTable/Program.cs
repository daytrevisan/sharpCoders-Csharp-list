// Leia um inteiro N (2 < N < 1000) e retorne a tabuada de 1 a 10 para N

using System;

namespace MultiplicationTable;
public class Program {
    public static void Main() {

        Console.WriteLine("Insira um número inteiro entre 2 e 1000: ");
        int input = int.Parse(Console.ReadLine());

        for(int count=1; count<11; count++) {
            int result = count*input;
            Console.WriteLine($"{count} x {input} = {result}");
        };

    }

}