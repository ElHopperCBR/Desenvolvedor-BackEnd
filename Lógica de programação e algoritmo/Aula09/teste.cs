//declaração de uma matriz 3x3
int [,] matriz = new int[3, 3];

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write($"Digite o valor para a posição [{i},{j}]");
        matriz[i,j] = int.Parse(Console.ReadLine());
    }
}

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write(matriz[i,j] + "\t");
    }
    Console.WriteLine();
}