
using Cars.Classes.Contextos;
using Microsoft.IdentityModel.Tokens;
using static System.Net.Mime.MediaTypeNames;

namespace Cars.Classes.Services
{
    internal static class Pesquisa
    {
        //Campo
        static EstoqueContexto contexto = new EstoqueContexto();


        //Métodos
        public static void Pesquisas(bool moto, bool carro, string texto, DataGridView dataGridView1)
        {
            if (moto.Equals(false) & carro.Equals(false) | moto.Equals(true) & carro.Equals(true))
            {
                Filtro(texto, dataGridView1);
            }
            else if (moto)
            {
                //Pesquisa por moto
                dataGridView1.DataSource = contexto.Estoque.Where(e => e.Tipo == 1).Select(e => new
                {
                    e.Tipo,
                    e.Modelo,
                    e.Quantidade,
                    Valor = e.Valor.ToString("C"),
                }).ToList();
            }
            else if (carro)
            {
                //Pesquisa por carro
                dataGridView1.DataSource = contexto.Estoque.Where(e => e.Tipo == 2).Select(e => new
                {
                    e.Tipo,
                    e.Modelo,
                    e.Quantidade,
                    Valor = e.Valor.ToString("C"),
                }).ToList();
            }
  
        }

        private static void Filtro(string texto, DataGridView dataGridView1)
        {
            if (texto.IsNullOrEmpty())
            {
                dataGridView1.DataSource = contexto.Estoque.Select(e => new
                {
                    e.Tipo,
                    e.Modelo,
                    e.Quantidade,
                    Valor = e.Valor.ToString("C"),
                }).ToList();
            }
            else
            {
                dataGridView1.DataSource = contexto.Estoque.Where(e => e.Modelo.Contains(texto))
                    .Select(e => new
                    {
                        e.Tipo,
                        e.Modelo,
                        e.Quantidade,
                        Valor = e.Valor.ToString("C"),
                    }).ToList();
            }
        }
    }
}
