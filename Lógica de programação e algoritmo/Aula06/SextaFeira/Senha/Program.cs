//Declaração de variavel
const int senha = 2002;
int i = 0;

//Entrada de dados
Console.Write("Digite a senha: ");
int n = int.Parse(Console.ReadLine());

while (true)
{
    if (senha == n)
    {
        break;
    }
    Console.WriteLine("Senha incorreta, tente novamente: ");
    n = int.Parse(Console.ReadLine());
    i++;
    Console.WriteLine($"Número de tentativas: {i}");
}
Console.WriteLine("Acesso permitido!");
