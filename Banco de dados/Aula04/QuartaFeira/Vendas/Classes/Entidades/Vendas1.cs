
namespace VendasSenai.Classes.Entidades
{
    internal class Vendas1
    {

        //Propriedades
        public int Id { get; set; }
        public DateTime DataCompra { get; set; }
        public string Tipo { get; set; }
        public string Marca { get; set; }
        public decimal Faturamento { get; set; }
        public decimal Lucro { get; set; }

        //Construtor
        public Vendas1(DateTime dataCompra, string tipo, string marca, decimal faturamento, decimal lucro)
        {
            DataCompra = dataCompra;
            Tipo = tipo;
            Marca = marca;
            Faturamento = faturamento;
            Lucro = lucro;
        }

    }
}
