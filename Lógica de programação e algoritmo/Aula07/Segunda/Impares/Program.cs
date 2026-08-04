using static System.Linq.Enumerable;
using static System.Console;

//Declaração de variaveis
int x, y, controle, control;
int impar = 0;

try
{
	//Entrada de dados
	WriteLine("Digite dois numeros: ");
	x = int.Parse(ReadLine()!);
	y = int.Parse(ReadLine()!);


	if (x < y)
	{
		controle = x;
		control = y;
	}
	else
	{
		controle = y;
		control = x;
	}

    foreach (int a in Range(controle, control))
    {
        if (a%2 != 0 & a != x & a!= y)
        {
			impar += a;
        }
        if (a == control)
        {
			break;
        }
    }

	WriteLine($"Soma dos impares: {impar}");
}
catch (Exception erro)
{

	WriteLine($"Valor inválido, ERRO: {erro}");
}
