//Coleção de dados
/* --  Array -- */
int[] numeros = { 0, 1, 2, 10, 4 };
string[] nomes = { "Clodoaldo", "Kelvin", "Cesar" };
char[] caracteres;
Console.WriteLine(numeros.Length);
Console.WriteLine(numeros[3]);
numeros[3] = 56;
Console.WriteLine(numeros[3]);
caracteres = new char[10];

/* -- Dicionairio -- */ 
Dictionary<string, double> salarios = new Dictionary<string, double>()
{
    {"Alice", 1.73 },
    {"Bob", 62.9},
    {"Clodoaldo", 14}
};

Console.WriteLine(salarios["Bob"]);
salarios.Add("SENAI", 8.96);
Console.WriteLine(salarios["SENAI"]);
salarios.Remove("Alice");

foreach (var item in salarios)
{
    Console.WriteLine(item.Key + " tem " + item.Value);
}

if (salarios.ContainsKey("Bob"))
{
    Console.WriteLine("Bob esta na coleção");
}

/* -- Lista -- */

List<int> lista1 = new List<int>();
lista1.Add(5600);
lista1.Add(600);
lista1.Add(0);
lista1.Add(50);
Console.WriteLine(lista1);
foreach (var item in lista1)
{
    Console.WriteLine(item);
}
lista1.Insert(2, 900);
lista1.Remove(600);

foreach (var item in lista1)
{
    Console.WriteLine(item);
}

lista1.Clear();

foreach (var item in lista1)
{
    Console.WriteLine(item);
}

/* -- Tuplas -- */
var pessoa = ("César", 34, 2.5, 'M');
Console.WriteLine(pessoa.Item1); //Nome
Console.WriteLine(pessoa.Item2); //Idade
Console.WriteLine(pessoa.Item3); //Salario
Console.WriteLine(pessoa.Item4); //Genero
pessoa.Item1 = "Clodoaldo";
Console.WriteLine(pessoa.Item1); //Nome
Console.WriteLine(pessoa.Item2); //Idade
Console.WriteLine(pessoa.Item3); //Salario
Console.WriteLine(pessoa.Item4); //Genero
var pessoa2 = (Nome: "César", Idade: 35);
