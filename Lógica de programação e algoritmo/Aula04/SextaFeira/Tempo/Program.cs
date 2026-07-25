// DateTime
// TimeSpan
/*
var horario = DateTime.Now;

DateTime data1 = new(1991, 8, 27);
DateTime date2 = new DateTime(1993, 6, 7);

var data = data1.AddDays(10);

Console.WriteLine(data.Month);
*/

//Declaração de variavies
int segundos, minutos, hora;

//Entrada de dados
Console.WriteLine("Digite a duração em segundos: ");
int totalsegundos = int.Parse(Console.ReadLine());

//Processamento de dados
hora = totalsegundos / 3600;
minutos = (totalsegundos % 3600) / 60;
segundos = (totalsegundos % 3600) % 60;

//Saída de dados
Console.WriteLine($"{hora}:{minutos}:{segundos}");





