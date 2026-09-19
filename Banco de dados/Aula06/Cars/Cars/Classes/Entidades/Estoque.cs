
namespace Cars.Classes.Entidades
{
    internal class Estoque
    {
        //Propriedades
        public int Id { get; set; }
        public string Modelo { get; set; }
        public int Tipo { get; set; }
        public decimal Valor { get; set; }
        public int Quantidade { get; set; }
        public string Foto { get; set; }

        //Construtor
        public Estoque(string modelo, int tipo, decimal valor, int quantidade, string foto)
        {
            Modelo = modelo;
            Tipo = tipo;
            Valor = valor;
            Quantidade = quantidade;
            Foto = foto;
        }

        public void RequisicaoEstoque(int qtd)
        {
            Quantidade -= qtd;
        }

    }
}
