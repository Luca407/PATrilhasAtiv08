using System;

class Program
{
    // Método que recebe uma string e retorna o número de caracteres
    static int ContarCaracteres(string texto)
    {
        return texto.Length;  // Propriedade Length retorna o número de caracteres da string
    }

    static void Main(string[] args)
    {
        // Testando o método ContarCaracteres
        Console.WriteLine("Digite uma frase ou palavra:");
        string entrada = Console.ReadLine();
        
        int quantidadeDeCaracteres = ContarCaracteres(entrada);
        Console.WriteLine("O número de caracteres é: " + quantidadeDeCaracteres);
        Console.ReadKey();
    }
}
