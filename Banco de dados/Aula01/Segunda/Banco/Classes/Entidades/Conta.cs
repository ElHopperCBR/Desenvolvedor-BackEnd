namespace Banco.Classes.Entidades
{
    internal class Conta
    {
        //Propriedades
        public int Id { get; set; }
        public int NumeroDaConta { get; set; }
        public string TitularDaConta { get; set; }
        public decimal SaldoDaConta { get; set; }

        //Construtores
        private Conta() { }

        public Conta(int numeroDaConta, string titularDaConta, decimal saldoDaConta)
        {
            NumeroDaConta = numeroDaConta;
            TitularDaConta = titularDaConta;
            SaldoDaConta = saldoDaConta;
        }
        //Métodos
        public void Depositar(decimal quantidade)
        {
            SaldoDaConta += quantidade;
        }
        public void Sacar(decimal quantidade)
        {
            SaldoDaConta -= quantidade;
        }
        public void ExibirDados()
        {
            Console.WriteLine("-- Dados da conta --" +
                $"\nNúmero da conta: {NumeroDaConta}" +
                $"\nTitular da conta: {TitularDaConta}" +
                $"\nSaldo da conta: {SaldoDaConta:c}" +
                $"\n---------------------------------");
        }
    }
}
