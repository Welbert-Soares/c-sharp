using System;

namespace OperadoresDeAtribuicao
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine(a);

            a += 2;
            Console.WriteLine(a);

            a *= 3;
            Console.WriteLine(a);

            Console.WriteLine("-------------");

            string s = "ABC";
            Console.WriteLine(s);

            s += "DEF";
            Console.WriteLine(s);

            Console.WriteLine("-------------");

            int b = 10;
            b++;
            Console.WriteLine(b);
            b--;
            Console.WriteLine(b);

            Console.WriteLine("-------------");

            int c = 10;
            int d = ++c;
            Console.WriteLine(c);
            Console.WriteLine(d);
        }
    }
}   