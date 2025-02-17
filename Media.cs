using System;
using System.Collections.Generic;
using System.Linq;


    class Program
    {
        // Método para calcular a média de uma lista de números
        static double CalcularMedia(List<int> numeros)
        {
            return numeros.Average(); // Usa o método Average do LINQ para calcular a média
        }

        static void Main()
        {
            List<int> numeros = new List<int> { 10, 20, 30, 40 };
            Console.WriteLine(CalcularMedia(numeros));  // Saída: 25
            Console.ReadKey();
        }
    }
