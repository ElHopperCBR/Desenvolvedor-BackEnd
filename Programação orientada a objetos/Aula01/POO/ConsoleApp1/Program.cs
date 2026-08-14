//Declaração de variaveis
double ladoA_x, ladoB_x, ladoC_x;
double ladoA_y, ladoB_y, ladoC_y;
double perimetro_X, perimetro_Y;
double area_X, area_Y;

//Entrada de dados
Console.WriteLine("Entre com as medidas do triângulo X");
Console.Write("Lado A = ");
ladoA_x = double.Parse(Console.ReadLine());
Console.Write("Lado B = ");
ladoB_x = double.Parse(Console.ReadLine());
Console.Write("Lado C = ");
ladoC_x = double.Parse(Console.ReadLine());

Console.WriteLine("Entre com as medidas do trinângulo Y");
Console.Write("Lado A = ");
ladoA_y = double.Parse(Console.ReadLine());
Console.Write("Lado B = ");
ladoB_y = double.Parse(Console.ReadLine());
Console.Write("Lado C = ");
ladoC_y = double.Parse(Console.ReadLine());

//Processamento de dados
//Perimetros do triangulos
perimetro_X = (ladoA_x + ladoB_x + ladoC_x) / 2;
perimetro_Y = (ladoA_y + ladoB_y + ladoC_y) / 2;
//Areas do triangulos
area_X = Math.Sqrt(perimetro_X * (perimetro_X - ladoA_x) * (perimetro_X - ladoB_x) * (perimetro_X - ladoC_x));
area_Y = Math.Sqrt(perimetro_Y * (perimetro_Y - ladoA_y) * (perimetro_Y - ladoB_y) * (perimetro_Y - ladoC_y));

//Saida de dados
Console.WriteLine($"Áre do triângulo X: {area_X}");
Console.WriteLine($"Áre do triângulo Y: {area_Y}");
Console.WriteLine(area_X > area_Y ? "Maior área é X" : "Maior área é do Y");