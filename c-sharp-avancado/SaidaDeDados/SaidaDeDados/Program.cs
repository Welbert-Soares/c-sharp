using System;
using System.Globalization;

namespace SaidaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            char genero = 'F';
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";


            Console.Write("Bom dia!"); //Não quebra linha
            Console.WriteLine("Boa tarde!");
            Console.WriteLine("Boa noite!");
            Console.WriteLine("--------------");
            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(nome);
            Console.WriteLine(saldo.ToString("F2")); //Duas casas decimais
            Console.WriteLine(saldo.ToString("F4")); //Quatro casas decimais
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture)); //Ponto ao invés de vírgula
        }
    }
}
