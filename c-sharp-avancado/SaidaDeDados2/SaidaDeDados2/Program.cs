using System;
using System.Globalization;


namespace SaidaDeDados2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";

            Console.WriteLine("{0} tem {1} anos e tem saldo igual a R$ {2} reais", nome, idade, saldo.ToString("F2")); // Placeholders

            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a R$ {saldo:F2} reais"); // Interpolação

            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a R$ " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais"); // Concatenação
        }
    }
}   
