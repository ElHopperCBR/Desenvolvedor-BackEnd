//Declaração de variaveis
int codigo, quantidade;
double preco;

//Entrada de dados
Console.Write("Digite o código do produto: ");
codigo = int.Parse(Console.ReadLine());
Console.Write("Digite a quantidade de produto: ");
quantidade = int.Parse(Console.ReadLine());

//Estrtura de controle de seleção - switch case
switch (codigo)
{
    case 1:
        //Produto 1 - R$ 5.00
        Console.WriteLine($"Valor a pagar: R$ {quantidade * 5.00}");
        break;
    case 2:
        //Produto 2 - R$ 3.50
        Console.WriteLine($"Valor a pagar: R$ {quantidade * 3.50}");
        break;
    case 3:
        //Produto 3 - R$ 4.80
        Console.WriteLine($"Valor a pagar: R$ {quantidade * 4.80}");
        break;
    case 4:
        //Produto 4 - R$ 8.90
        Console.WriteLine($"Valor a pagar: R$ {quantidade * 8.90}");
        break;
    case 5:
        //Produto 5 - R$ 7.32
        Console.WriteLine($"Valor a pagar: R$ {quantidade * 7.32}");
        break;
    default:
        Console.WriteLine("Código invalido, tente novamente!");
        break;
}
