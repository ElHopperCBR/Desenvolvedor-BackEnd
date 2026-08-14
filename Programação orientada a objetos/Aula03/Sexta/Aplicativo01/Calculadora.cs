namespace Aplicativo01
{
    internal class Calculadora
    {
        //Membros
        // 1° - Campos
        double raio;
        public const double pi = 3.1415;

        //2° - Construtor
        public Calculadora(double raio)
        {
            this.raio = raio;
        }

        //3° - Métodos
        public double Circunferencia() 
        {
            return 2 * pi * raio;
        }

        public double Volume()
        {
            return (4 * pi * Math.Pow(raio, 3)) / 3;
        }

        public void PI()
        {
            Console.WriteLine(pi);
        }

        

    }
}
