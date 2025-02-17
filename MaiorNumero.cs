using System;
using System.Collections.Generic;

class Program
{
  
    static int MaiorNumero(List<int> numeros)
    {
        int maior = numeros[0]; 

        foreach (int numero in numeros)
        {
            if (numero > maior)
            {
                maior = numero; 
            }
        }

        return maior;
    }

    static void Main(string[] args)
    {
        // Criando uma lista de números inteiros
        List<int> listaNumeros = new List<int>();

       
        Console.WriteLine("Digite quantos números você deseja inserir:");
        int quantidade = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < quantidade; i++)
        {
            Console.WriteLine("Digite o " + (i + 1) + "º número:");
            int numero = Convert.ToInt32(Console.ReadLine());
            listaNumeros.Add(numero); 
        }

      
        int maior = MaiorNumero(listaNumeros);

        
        Console.WriteLine("O maior número da lista é: " + maior);
        Console.ReadKey();
    }
}
