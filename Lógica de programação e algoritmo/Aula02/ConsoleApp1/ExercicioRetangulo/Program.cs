//Declaração de variaveis
double bAse;
double altura;
double area;
double perimetro;
double diagonal;

//Entrada de dados
Console.Write("Digite a base do retângulo: ");
bAse = double.Parse(Console.ReadLine());
Console.Write("Digite a altura do retângulo: ");
altura = double.Parse(Console.ReadLine());

//Processamento de dados
area = bAse * altura;
perimetro = bAse + altura + bAse + altura;
diagonal = Math.Sqrt(Math.Pow(bAse, 2) + Math.Pow(altura, 2));

//Saída de dados
Console.WriteLine($"--Dados do retângulo--\n" +
    $"Área = {area:f2}\n" + 
    $"Perimetro = {perimetro:f4}\n" +
    $"Diagonal = {diagonal:n}\n"); 