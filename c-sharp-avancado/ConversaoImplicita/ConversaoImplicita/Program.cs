using System;

namespace ConversaoImplicita
{
    class Program
    {
        static void Main(string[] args)
        {
            float x = 4.5f;

            double y = x; // Conversão implícita

            Console.WriteLine(y);

            Console.WriteLine("--------------------");

            double a;
            float b;

            a = 5.1;
            b = (float) a; // Conversão explícita

            Console.WriteLine(b);

            Console.WriteLine("--------------------");

            double c;
            int d;

            c = 5.1;
            d = (int) c; // Conversão explícita

            Console.WriteLine(d);

            Console.WriteLine("--------------------");


            int e = 5;
            int f = 2;

            double resultado = (double) e / f; // Conversão explícita

            Console.WriteLine(resultado);


        }
    }
}