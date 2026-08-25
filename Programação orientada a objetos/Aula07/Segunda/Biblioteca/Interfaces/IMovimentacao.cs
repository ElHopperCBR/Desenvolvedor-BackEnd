namespace Biblioteca.Interfaces
{
    internal interface IMovimentacao
    {
        public void Emprestar(int quantia);
        public void Devolver(int quantia);
    }
}
