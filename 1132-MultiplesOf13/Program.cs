using System;

namespace MultiplesOf13;

public class Program {
    
    static bool IsMultipleOf13(int number) {
        return number % 13 == 0;
    }
    public static void Main() {

        int begin = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());
        int sum = 0;

        if(begin > end) {
            int aux = begin;
            begin = end;
            end = aux;
        }

        for(int i = begin; i <= end; i++) {
            if(!IsMultipleOf13(i)) {
                sum += i;
            }
        }

        Console.WriteLine(sum);
    }
}