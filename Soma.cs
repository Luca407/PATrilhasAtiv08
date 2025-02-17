using System;

class Program
{
    // Método que recebe uma string e retorna o número de caracteres
    static int soma(int x, int y)
    {
        return x+y;  // Propriedade Length retorna o número de caracteres da string
    }

    static void Main(string[] args)
    {
        // Testando o método ContarCaracteres
        Console.WriteLine("Digite um número:");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite um número:");
        int y = Convert.ToInt32(Console.ReadLine());
                                 
        int resultado = soma(x,y);
                                 
      
        Console.WriteLine("A soma é: " + resultado);
        Console.ReadKey();
    }
}
