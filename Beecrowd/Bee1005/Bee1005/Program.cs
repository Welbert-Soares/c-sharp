using System;
using System.Globalization;

double a, p1, b, p2, media, pSoma;
p1 = 3.5;
p2 = 7.5;
pSoma = 11.0;

a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
media = (a * p1 + b * p2) / pSoma;

Console.WriteLine("MEDIA = " +  media.ToString("F5"), CultureInfo.InvariantCulture);
