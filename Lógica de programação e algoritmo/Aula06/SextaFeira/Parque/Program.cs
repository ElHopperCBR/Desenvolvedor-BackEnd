using System;

int quantidadeVisitantes = LerInteiro("Digite a quantidade de visitantes: ");
int alturaMinima = LerInteiro("Digite a altura mínima permitida (em cm): ");
int alturaMaxima = LerInteiro("Digite a altura máxima permitida (em cm): ");

int totalPermitidos = 0;

for (int i = 1; i <= quantidadeVisitantes; i++)
{
    int alturaVisitante = LerInteiro($"Digite a altura do visitante {i} (em cm): ");

    if (alturaVisitante >= alturaMinima && alturaVisitante <= alturaMaxima)
    {
        totalPermitidos++;
    }
}

Console.WriteLine();
Console.WriteLine($"Total de pessoas que podem andar na montanha-russa: {totalPermitidos}");

static int LerInteiro(string mensagem)
{
    while (true)
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(mensagem);

        Console.ForegroundColor = ConsoleColor.Red;
        string? entrada = Console.ReadLine();

        Console.ResetColor();

        if (int.TryParse(entrada, out int valor))
        {
            return valor;
        }

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Valor inválido. Digite um número inteiro.");
        Console.ResetColor();
    }
}
