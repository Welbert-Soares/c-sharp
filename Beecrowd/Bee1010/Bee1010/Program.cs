using System;
using System.Globalization;

int id1, id2, numberP1, numberP2;
double valueP1, valueP2, total1, total2, totalGeral;

string[] p1 = Console.ReadLine().Split(" ");

id1 = int.Parse(p1[0]);
numberP1 = int.Parse(p1[1]);
valueP1 = double.Parse(p1[2], CultureInfo.InvariantCulture);

total1 = numberP1 * valueP1;

string[] p2 = Console.ReadLine().Split(" ");

id2 = int.Parse(p2[0]);
numberP2 = int.Parse(p2[1]);
valueP2 = double.Parse(p2[2], CultureInfo.InvariantCulture);

total2 = numberP2 * valueP2;

totalGeral = total1 + total2;

Console.WriteLine("VALOR A PAGAR = R$ " + totalGeral.ToString("F2", CultureInfo.InvariantCulture));
