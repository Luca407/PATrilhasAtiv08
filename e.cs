using System;
using System.Collections.Generic;

class Program
{
    static string Metodo(List<string> lista)
    {
        string resultado = "";
        foreach (var item in lista) resultado += item;
        return resultado;
    }

    static void Main()
    {
        List<string> palavras = new List<string> { "Olá", " ", "Mundo", "!" };
        Console.WriteLine(Metodo(palavras));
        Console.ReadKey();
    }
}

