using System;
using System.Globalization;

namespace Bee1002
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio, area, n;
            n = 3.14159265358979323846;

            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = n * (Math.Pow(raio, 2));

            Console.WriteLine("A=" +  area.ToString("F4", CultureInfo.InvariantCulture));

        }
    }
}
