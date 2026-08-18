namespace Banco
{
    public class ContaBancaria
    {
        //1° - Campos
        private string titular;
        private int numero;
        private double saldo;


        //2 ° - Propriedades
        protected string TitularDaConta
        {
            get { return titular; }
            set {
                if (value != null | value != "")
                {
                    
                    titular = value;
                }
                else
                {
                    Console.WriteLine("Valor de campo invalido");
                }
            }
        }

        protected int NumeroDaConta
        {
            get { return numero; }
            private set { numero = value; }
        }

        protected double SaldoDaConta
        {
            get { return saldo; }
            set { saldo = value; }
        }

        //3° - Construtor
        public ContaBancaria(string titularDaConta, int numeroDaConta)
        {
            TitularDaConta = titularDaConta;
            NumeroDaConta = numeroDaConta;
            SaldoDaConta = 0;
        }

        public ContaBancaria(string titularDaConta, int numeroDaConta, double saldoDaConta)
        {
            TitularDaConta = titularDaConta;
            NumeroDaConta = numeroDaConta;
            SaldoDaConta = saldoDaConta;
        }


        //4° - Métodos
        public void Deposito(double quantia)
        {
            SaldoDaConta += quantia;
        }

        public void Saque(double quantia)
        {
            if (quantia <= 0)
            {
                Console.WriteLine("Valor invalido, inseria valor positivos ou diferente de zero");
            }
            else
            {
                SaldoDaConta -= quantia + 5.00;
            }
        }

        public string ExibirDados()
        {
            return $"Dados da conta:\n" +
                $"\tTitular da conta: {TitularDaConta}\n" +
                $"\tNúmero da conta: {NumeroDaConta}\n" +
                $"\tSaldo da conta: {SaldoDaConta:c}";
        }
    }
}
