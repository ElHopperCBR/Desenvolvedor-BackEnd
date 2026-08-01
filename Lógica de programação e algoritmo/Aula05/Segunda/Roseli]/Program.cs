//Entrada de dados
Console.Write("Digite o valor de A: ");
double a = double.Parse(Console.ReadLine());
Console.Write("Digite o valor de B: ");
double b = double.Parse(Console.ReadLine());
Console.Write("Digite o valor de C: ");
double c = double.Parse(Console.ReadLine());

//Processamento de dados
Console.WriteLine(Delta(a, b, c));

double Delta(double q, double w, double e)
{
    double delta;
    delta = (w * w) - 4 * q * e;
    return delta;
}