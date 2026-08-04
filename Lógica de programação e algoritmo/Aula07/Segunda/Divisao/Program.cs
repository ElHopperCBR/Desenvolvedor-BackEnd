//Declaração de variaveis
int n;
double x, y;

try
{
    //Entrada de dados    
    Console.Write("Quantos casos você vai digitar? ");
    n = int.Parse(Console.ReadLine());

    for (int i = 0; i < n; i++)
    {
        Console.Write("Entre com o numerador: ");
        x = double.Parse(Console.ReadLine());
        Console.Write("Entre com o denominador: ");
        y = double.Parse(Console.ReadLine());

        if (y != 0)
        {
            Console.WriteLine($"Divisão = {(x / y):f2}");
        }
        else
        {
            Console.WriteLine("Divisão impossivel");
        }
    }
}
catch (Exception erro)
{

    Console.WriteLine($"Valor invalido, erro: {erro}"); ;
}