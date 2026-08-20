using Contrato.Classes.Entidades;

Empresa SENAI = new Empresa("Roberto Mange", "Clodoaldo");
SENAI.RegistrarContratoFuncionario(10, 50);


Console.WriteLine(SENAI);

SENAI = null;

Console.WriteLine(SENAI);
Console.WriteLine();
