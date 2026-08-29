using Abstracao.Classes.Entidades;
using Abstracao.Enumeracoes;

List<Forma> formas = new();

Console.Write("Quantas formas geometriacas quer digitar? ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Console.WriteLine("Dados da forma # " + (i+1));
    Console.Write("Retângulo ou Circulo (R/C): ");
    char escolha = char.Parse(Console.ReadLine().ToUpper());
    Console.Write("Qual é a cor do objeto:" +
        " -- 1 - Vermelho, 2 - Azul, 3 - Amerelo --  ");
    int cor = int.Parse(Console.ReadLine());

    if (escolha.Equals('R'))
    {
        Console.Write("Digite a largura do retângulo: ");
        double largura = double.Parse(Console.ReadLine());
        Console.Write("Digite a altura do retêngulo: ");
        double altura = double.Parse(Console.ReadLine());
        formas.Add(new Retangulo((Cor)cor,largura,altura));
    }
    else if (escolha.Equals('C'))
    {
        Console.Write("Digite o raio do circulo: ");
        double raio = double.Parse(Console.ReadLine());
        formas.Add(new Circulo((Cor)cor,raio));
    }
    else
    {
        Console.WriteLine("Objeto selecionado não está lista!");
    }
}

Console.WriteLine("Lista de formas digitadas e suas area: ");

foreach (var figurinhas in formas)
{
    Console.Write($"{figurinhas.ToString()} - Cor: {figurinhas.Cor()} -Area da figura: ");
    figurinhas.Area();
   
}
