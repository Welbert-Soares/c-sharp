using System;
using System.Globalization;

namespace exercicio001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome completo: ");
            string name = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa? ");
            int rooms = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço do produto: ");
            float price = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite seu último nome, idade e altura (mesma linha): ");
            string[] vet = Console.ReadLine().Split(' ');
            string lastName = vet[0];
            int age = int.Parse(vet[1]);
            double height = double.Parse(vet[2], CultureInfo.InvariantCulture);


            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("                    Saida esperada                           ");
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine(name);
            Console.WriteLine(rooms);
            Console.WriteLine(price.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(lastName);
            Console.WriteLine(age);
            Console.WriteLine(height.ToString( CultureInfo.InvariantCulture));


        }
    }
}