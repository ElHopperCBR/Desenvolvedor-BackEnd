//Declaração de variveis
Dictionary<int,double> produtos = new Dictionary<int, double>()
{
   //Código , Valor
    {  1    , 5.00 },
    {  2    , 3.50 },
    {  3    , 4.80 },
    {  4    , 8.90 },
    {  5    , 7.32 }
};
int codigo, quantidade;
double preco;

try
{
    //Entrada de dados
    Console.Write("Digite o código do produto: ");
    codigo = int.Parse(Console.ReadLine());
    Console.Write("Digite a quantidade de produto: ");
    quantidade = int.Parse(Console.ReadLine());

    //Processamento de dados
    preco = quantidade * produtos[codigo];

    //Saida de dados
    Console.WriteLine($"Valor a pagar: {preco:c}");
}
catch (Exception e)
{
    Console.WriteLine("Valor inválido, erro: " + e); ;
}