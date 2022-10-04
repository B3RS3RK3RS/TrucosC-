using System;

namespace Interpolacion_de_Cadenas
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre = "Gustavo";
            DateTime dt = DateTime.Now;

            //FORMATO DE COMPOSICION
            Console.WriteLine("Nombre: {0}, Fecha: {1}", nombre, dt);
            //FORMATO DE INTERPOLACION
            Console.WriteLine($"Nombre: {nombre}, Fecha: {dt}");

            //TAMBIEN SE PUEDEN HACER CALCULOS DIRECTAMENTE
            Console.WriteLine($"Redondeo: {Math.Round(5.6)}");
        }
    }
}
