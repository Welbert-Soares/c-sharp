using System;
using System.Globalization;

int id, hoursJob;
double hoursValue, moneyJob;

id = int.Parse(Console.ReadLine());
hoursJob = int.Parse(Console.ReadLine());

hoursValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
moneyJob = hoursJob * hoursValue;

Console.WriteLine("NUMBER = " + id);
Console.WriteLine("SALARY = U$ " + moneyJob.ToString("F2", CultureInfo.InvariantCulture));


