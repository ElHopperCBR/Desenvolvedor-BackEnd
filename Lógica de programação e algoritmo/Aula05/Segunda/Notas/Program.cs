//Declaração variaveis
double nota1, nota2, notafinal;

try
{
    //Entrada de dados
    Console.Write("Digite a 1° nota: ");
    nota1 = double.Parse(Console.ReadLine());
    Console.Write("Digite a 2° nota: ");
    nota2 = double.Parse(Console.ReadLine());
    //Processamento de dados
    Nota();
    //Saída de dados
    Console.WriteLine($"Notal final = {notafinal:f1}");
    if (notafinal > 60 & notafinal < 70 | notafinal == 100)
    {
        Console.WriteLine("Recuperação");
    }
    else if (notafinal == 80)
    {
        Console.WriteLine("parabens pela nota");
    }
    else
    {
        Console.WriteLine("Aprovado");
    }
}

catch
{
    Console.WriteLine("Digite valores válidos");
}

double Nota()
{
    notafinal = nota1 + nota2;
    return notafinal;
}
