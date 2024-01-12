using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = Console.ReadLine();
            string cor1 = Console.ReadLine();
            string cor2 = Console.ReadLine();
            string cor3 = Console.ReadLine();

            string[] vet = Console.ReadLine().Split(' ');
            string p1 = vet[0];
            string p2 = vet[1];
            string p3 = vet[2];

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(frase);
            Console.WriteLine(cor1);
            Console.WriteLine(cor2);
            Console.WriteLine(cor3);
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);
        }   

    }
}