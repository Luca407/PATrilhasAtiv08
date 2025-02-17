using System;

class Program
{
    	
    static double Quadrado(double x)
    {
        return x * x;
    }

    static void Main(string[] args)
    {
       
        Console.WriteLine("Digite um número:");
        double x = Convert.ToInt32(Console.ReadLine());
        
        
        double resultado = Quadrado(x);
        Console.WriteLine("O quadrado de " + x + " é: " + resultado);
        
        
        Console.ReadKey();
    }
}
