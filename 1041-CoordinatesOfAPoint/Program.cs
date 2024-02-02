// Leia dois números flutuantes (x and y) que representam as coordenadas de um ponto no plano
// Determine em qual quadrante está o ponto (Q1, Q2, Q3, Q4), ou se está no eixo X ou Y ou na origem (x=y=0)

using System;

namespace CoordinatesOfAPoint;

public class Program
{
    public static void Main()
    {
        Console.Write("Digite duas coordenadas em um plano: ");
        string[] input = Console.ReadLine().Split();
        double x = double.Parse(input[0]);
        double y = double.Parse(input[1]);
        
        if(x == 0 && y == 0) {
            Console.WriteLine("Origem");
        }
        
        if(x == 0 && y != 0) {
            Console.WriteLine("Eixo Y");
        } else if (x != 0 && y == 0) {
            Console.WriteLine("Eixo X");
        }
        
        if(x > 0) {
            if(y > 0) {
                Console.WriteLine("Q1");
            } else if(y < 0) {
                Console.WriteLine("Q4");
            }
        } else if(x < 0) {
            if(y > 0) {
                Console.WriteLine("Q2");
            } else if(y < 0) {
                Console.WriteLine("Q3");
            }
        }

    }
}