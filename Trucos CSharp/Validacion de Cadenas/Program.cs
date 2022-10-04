using System;

namespace Validacion_de_Cadenas
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre = string.Empty;

            do
            {
                Console.WriteLine("Escriba su nombre");
                nombre = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(nombre));
            //} while (string.IsNullOrEmpty(nombre));




            string subc = "tavo";
            if (nombre.Contains(subc))
            {
                var i = nombre.IndexOf(subc);   //PARA SABER LA POSICION DE LA SUBCADENA
                Console.WriteLine($"El nombre contiene la subcadena en la posición: {i}");
            }
        }
    }
}
