
using System;
using System.Collections.Generic;

class Program
{

    static bool Metodo(int numero)
    {
        return numero % 2 == 0;
    }

    static void Main()
    {
        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());
        Console.WriteLine(Metodo(numero));
      // false = impar
      // true = par
            
        Console.ReadKey();
    }
}
