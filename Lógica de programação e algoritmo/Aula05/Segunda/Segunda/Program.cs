const string JANELA = "Problema medidas";
Console.Title = JANELA;

//Declaração de variaveis
double a, b, c, quadrado, triangulo, trapezio;

//Entrada de dados
Console.Write("Digite a medida A: ");
a = double.Parse(Console.ReadLine());
Console.Write("Digite a medida B: ");
b = double.Parse(Console.ReadLine());
Console.Write("Digite a medida C: ");
c = double.Parse(Console.ReadLine());

//Processamento de dados
AreaQuadrado();
AreaTriangulo();
AreaTrapezio();

//Saída de dados
Saida();

Console.ReadKey();

double AreaQuadrado()
{
    quadrado = a * a;
    return quadrado;
}

double AreaTriangulo()
{
    triangulo = (a * b) / 2;
    return triangulo;
}

double AreaTrapezio()
{
    trapezio = ((a + b) * c) / 2;
    return trapezio;
}

void Saida()
{
    Console.WriteLine($"A área do quadrado é {quadrado:f4}\n" +
        $"A área do triângulo é {triangulo:f4}\n" +
        $"A área do trapézio é {trapezio:f4}");
}