//Declaração de variaveis
int numero1;
int numero2;
int numero3;
bool pergunta1;
bool pergunta2;
bool pergunta3;
bool pergunta4;
bool logica1;
bool logica2;
bool logica3;

//Entrada de dados
Console.Write("Digite o primeiro valor: ");
numero1 = int.Parse(Console.ReadLine());
Console.Write("Digite o segundo valor: ");
numero2 = int.Parse(Console.ReadLine());
Console.Write("Digite o terceiro valor: ");
numero3 = int.Parse(Console.ReadLine());

//Processamento de dados
pergunta1 = numero1 == numero3;
pergunta2 = numero1 != numero2;
pergunta3 = numero2 > numero1;
pergunta4 = numero2 <= numero3;

logica1 = pergunta1 & pergunta3;
logica2 = pergunta2 | pergunta4;
logica3 = !pergunta1;

//Saída de dados
Console.WriteLine("--Comparações--");
Console.WriteLine($"O 1° valor é igual ao 3° valor? R: {(pergunta1 ? "Verdadeiro" : "Falso")}");
Console.WriteLine($"O 1° valor é diferente do 2° valor? R: {(pergunta2 ? "Verdadeiro" : "Falso")}");
Console.WriteLine($"O 2° valor é maior que 1° valor? R: {(pergunta3 ? "Verdadeiro" : "Falso")}");
Console.WriteLine($"O 2° valor é menor ou igual que 3° valor? R: {(pergunta4 ? "Verdadeiro" : "Falso")}");
Console.WriteLine("--Lógicas--");
Console.WriteLine($"Se a pergunta 1 e pergunta 3 são verdadeiras. R: {(logica1 ? "Verdadeiro" : "Falso")}");
Console.WriteLine($"Se a pergunta 2 e pergunta 4 pelo menos uma é verdadeira. R: {(logica2 ? "Verdadeiro" : "Falso")}");
Console.WriteLine($"Se a negação da primeira pergunta é verdadeira. R: {(logica3 ? "Verdadeiro" : "Falso")}");

