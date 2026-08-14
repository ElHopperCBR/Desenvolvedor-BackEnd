//Declaração de variaveis
double raio, circunferencia, volume;
const double pi = 3.1415;

//Entrada de dados
Console.Write("Entre com o valor do raio da circunferencia: ");
raio = double.Parse(Console.ReadLine());

//Processamento de dados
circunferencia = 2 * pi * raio;
volume = (4 * pi * Math.Pow(raio, 3)) / 3;

//Saída de dados
Console.WriteLine($"Circunferencia: {circunferencia:f2}" +
    $"Volume: {volume:f2}" +
    $"PI = {pi:f2}");