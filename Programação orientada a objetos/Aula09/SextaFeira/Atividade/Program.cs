
using Atividade.Classes.Entidades;
using Atividade.Classes.Servicos;
using Atividade.Interfaces;

IImposto fisica = new ImpostosF();
Pessoa cesar = new Pessoa_Fisica("Clodoaldo", 1000, fisica, Atividade.Enumeracoes.Tipo.Pessoa_Fisica, 500 );

Console.WriteLine(cesar.ExibirDados());