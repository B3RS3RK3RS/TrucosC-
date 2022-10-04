using System;

namespace Validacion_de_Cadenas
{
    class Program
    {
        static void Main(string[] args)
        {
            //string nombre = string.Empty;

            //do
            //{
            //    Console.WriteLine("Escriba su nombre");
            //    nombre = Console.ReadLine();
            //} while (string.IsNullOrWhiteSpace(nombre));
            ////} while (string.IsNullOrEmpty(nombre));

            //string subc = "tavo";
            //if (nombre.Contains(subc))
            //{
            //    var i = nombre.IndexOf(subc);   //PARA SABER LA POSICION DE LA SUBCADENA
            //    Console.WriteLine($"El nombre contiene la subcadena en la posición: {i}");
            //}


            //COMPARAR UNA ENTRADA CON UNA CADENA Y VER SI COINCIDE EN EL INICIO O FIN
            string entrada = "GGCG";
            string cadena = "GGcgCGUGGGCUAGCGCCACUCAAAAGGCCCAU";

            int coincidenciaInicio = 0;
            int coincidenciaFin = 0;

            for (int i = 0; i < cadena.Length - 1; i += 4)
            {
                string c = cadena.Substring(i, 4);
                if (c.StartsWith(entrada[0]))
                    coincidenciaInicio += 1;
                if (c.EndsWith(entrada[3]))
                    coincidenciaFin += 1;
            }
            Console.WriteLine($"Inicio coincide en: {coincidenciaInicio} veces");
            Console.WriteLine($"Inicio coincide en: {coincidenciaFin} veces");
        }
    }
}