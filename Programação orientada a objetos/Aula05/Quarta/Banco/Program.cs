using Banco.Classes.Entidades;

ContaPessoaFisica clodoaldo;
clodoaldo = new ContaPessoaFisica("Clodoaldo", 123456, 1000);

ContaPessoaJuridica SENAI;
SENAI = new ContaPessoaJuridica("Skaf", 5555, 5000, 1000);

SENAI.Saque(1000);
SENAI.Deposito(52);
clodoaldo.Saque(50);
clodoaldo.Deposito(600);
SENAI.Limite(1000);

