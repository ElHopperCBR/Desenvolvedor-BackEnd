namespace Aplicativo01
{
    internal static class Calculadora
    {
        //Membros
        // 1° - Campos        
        public static double pi = 3.1415;

        //3° - Métodos
        public static double Circunferencia(double raio) 
        {
            return 2 * pi * raio;
        }

        public static double Volume(double raio)
        {
            return (4 * pi * Math.Pow(raio, 3)) / 3;
        }

        public static void PI()
        {
            Console.WriteLine(pi);
        }

        

    }
}
