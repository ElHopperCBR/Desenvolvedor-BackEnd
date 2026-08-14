using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        CultureInfo ci = CultureInfo.InvariantCulture;

        Console.Write("Base do retângulo: ");
        double baseRetangulo = double.Parse(Console.ReadLine()!, ci);

        Console.Write("Altura do retângulo: ");
        double altura = double.Parse(Console.ReadLine()!, ci);

        Func<double, double, double> calcularArea = (b, h) => b * h;
        Func<double, double, double> calcularPerimetro = (b, h) => 2 * (b + h);
        Func<double, double, double> calcularDiagonal = (b, h) => Math.Sqrt(Math.Pow(b, 2) + Math.Pow(h, 2));

        double area = calcularArea(baseRetangulo, altura);
        double perimetro = calcularPerimetro(baseRetangulo, altura);
        double diagonal = calcularDiagonal(baseRetangulo, altura);

        Console.WriteLine();
        Console.WriteLine($"AREA = {area.ToString("F4", ci)}");
        Console.WriteLine($"PERIMETRO = {perimetro.ToString("F4", ci)}");
        Console.WriteLine($"DIAGONAL = {diagonal.ToString("F4", ci)}");
    }
}