using System.Globalization;


CultureInfo CI = CultureInfo.InvariantCulture;

double b, a, area, perimetro, diagonal;

Console.Write("Base do retangulo: ");
b = double.Parse(Console.ReadLine(), CI);

Console.Write("Altura do retangulo: ");
a = double.Parse(Console.ReadLine(), CI);

area = a * b;

Console.WriteLine("AREA = " + area.ToString("F4", CI));

perimetro = 2 * (a + b);
diagonal = Math.Sqrt((Math.Pow(a, 2) + Math.Pow(b, 2)));

Console.WriteLine("PERIMETRO = " + perimetro.ToString("F4", CI));
Console.WriteLine("DIAGONAL = " + diagonal.ToString("F4", CI));