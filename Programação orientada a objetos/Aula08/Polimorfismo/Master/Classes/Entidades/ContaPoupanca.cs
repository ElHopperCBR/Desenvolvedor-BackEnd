namespace Master.Classes.Entidades
{
    internal class ContaPoupanca : Conta
    {
        //Campos
        private double taxa;

        //Propriedades
        protected double TaxaDeJuros
        {
            get { return taxa; }
            set { taxa = value/100; }
        }

        //Construtores
        public ContaPoupanca(string titularDaConta, int numeroDaConta, double taxa) : base(titularDaConta, numeroDaConta)
        {
            TaxaDeJuros = taxa;
        }

        public ContaPoupanca(string titularDaConta, int numeroDaConta, double saldoDaConta, double taxa) : base(titularDaConta, numeroDaConta, saldoDaConta)
        {
            TaxaDeJuros = taxa;
        }

        //Métodos
        public override void Saque(double qtd)
        {
            SaldoDaConta = qtd + (qtd * taxa);
        }

        public override void ExibirDados()
        {
            base.ExibirDados();
            Console.WriteLine($"Taxa de saque: {(TaxaDeJuros * 100):f2} %");
        }
    }
}
