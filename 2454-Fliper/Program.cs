// Através da combinação de cada uma das portas (R ou S), se aberta ou fechada, retornar por qual caminho a bolinha seguirá 

using System;

namespace Fliper;
public class Program {
    private static void Main() {

        Console.WriteLine("Entre com o número das portas: ");
        //string[] leitura = {"0", "1"};
        string[] dados = Console.ReadLine().Split(" ");

        int P = int.Parse(dados[0]);
        int R = int.Parse(dados[1]);

        if(P == 0)
            Console.WriteLine("C");
        else if(R == 0)
            Console.WriteLine("B");
        else
            Console.WriteLine("A");

    }

}
