using Triangulo_Com_POO;
//Declaração de variaveis - Instanciação
Triangulo x = new();
Triangulo y = new();

//Entrada de dados
Console.WriteLine("Dados do triangulo X:");
Console.Write("Lado A = ");
x.a = double.Parse(Console.ReadLine());
Console.Write("Lado B = ");
x.b = double.Parse(Console.ReadLine());
Console.Write("Lado C = ");
x.c= double.Parse(Console.ReadLine());

Console.WriteLine("Dados do triangulo Y: ");
Console.Write("Lado A = ");
y.a = double.Parse(Console.ReadLine());
Console.Write("Lado B = ");
y.b = double.Parse(Console.ReadLine());
Console.Write("Lado C = ");//
y.c = double.Parse(Console.ReadLine());

//Processamento de dados - Saida de dados
Console.WriteLine($"Area do triangulo X: {x.Area():f2}");
Console.WriteLine($"Area do triangulo Y: {y.Area():f2}");