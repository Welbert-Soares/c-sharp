using System;
using System.Globalization;
using System.Security.AccessControl;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            double b, h, metro, area, price;

            Console.WriteLine("Qual a largura do terreno(base): ");
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Qual a profundidade do terreno(altura): ");
            h = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Qual o preço do metro quadrado? ");
            metro = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            area = b * h;

            price = metro * area;

            Console.WriteLine("A área do terreno é de " + area.ToString("F2", CultureInfo.InvariantCulture) + " metros quadrados, e o valor do terreno é de R$" + price.ToString("F2", CultureInfo.InvariantCulture) + " reais.");

        }
    }
}