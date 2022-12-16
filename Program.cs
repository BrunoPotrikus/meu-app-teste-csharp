// See https://aka.ms/new-console-template for more information

using System;

class Program
{
    static void Main(string[] args)
    {
        int idade; //Certo
        int idade1 = 25; //Certo
        var idade2 = 25; //Certo
        var idade3; // Errado

        const int IDADE_MINIMA;
        const int IDADE_MINIMA1 = 25;
        const var IDADE_MINIMA2 = 25; // Errado, pois não se usa constante com var
        const var IDADE_MINIMA3; // Não se usa constantes com var
        
        var texto = "Testando";
        Console.WriteLine(texto);
    }
}
