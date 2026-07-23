using static System.Console;

try
{
    //Declaração de variaveis
    int a, b, c;
    double area_q, area_t, area_tp;

    //Entrada de dados
    Write("Digite o valor de A: ");
    a = int.Parse(ReadLine());
    Write("Digite o valor de B: ");
    b = int.Parse(ReadLine());
    Write("Digite o valor de C: ");
    c = int.Parse(ReadLine());

    //Processamento de dados
    area_q = Math.Pow(a, 2);
    area_t = (a * b) / 2;
    area_tp = ((a + b) * c) / 2;

    //Saída de dados
    WriteLine($"Area do quadrado = {area_q:f4}");
    WriteLine($"Area do triangulo = {area_t:f4}");
    WriteLine($"Area do trapezio = {area_tp:f4}");
}
catch
{
    WriteLine("Digite um valor valido");
}
finally
{
    WriteLine("Encerrando programa");
}


