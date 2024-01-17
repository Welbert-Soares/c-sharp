using System;
using System.Globalization;

double a, b, c, media, p1, p2, p3, pSoma;
p1 = 2;
p2 = 3;
p3 = 5;
pSoma = 10;

a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

media = (a * p1 + b * p2 + c * p3) / pSoma;

Console.WriteLine("MEDIA = " + media.ToString("F1", CultureInfo.InvariantCulture));
