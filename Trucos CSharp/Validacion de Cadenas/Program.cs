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
        }
    }
}
