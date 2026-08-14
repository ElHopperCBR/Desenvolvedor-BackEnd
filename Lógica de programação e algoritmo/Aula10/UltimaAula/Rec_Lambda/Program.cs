//Entrada de dados
Console.Write("Base do retângulo: ");
double baseR = double.Parse(Console.ReadLine());
Console.Write("Altura do retângulo: ");
double alturaR = double.Parse(Console.ReadLine());

//Processamento
Func<double, double, double> calc_area = (b, a) => b * a;
Func<double, double, double> calc_perimetro = (b, a) => 2 * (b + a);
Func<double, double, double> calc_diagonal = (b, a) => Math.Sqrt((b * b) + (a * a));

double area = calc_area(baseR, alturaR);
double perimetro = calc_perimetro(baseR, alturaR);
double diagonal = calc_diagonal(baseR, alturaR);  


//Saída de dados
Console.WriteLine($"Area = {area.ToString()}, Perimetro = {perimetro.ToString()}, Diagonal = {diagonal.ToString()}");

