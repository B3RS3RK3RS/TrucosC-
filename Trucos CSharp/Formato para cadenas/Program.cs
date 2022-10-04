using System;

namespace Formato_para_cadenas
{
    class Program
    {
        static void Main(string[] args)
        {
            //TOMANDO DE REFERENCIA EL PROYECTO DE VALIDACION DE CADENAS
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
                string imprime = String.Format("{0, -10}: {1}", i.ToString(), c.ToUpper());
                Console.WriteLine(imprime);
            }
            Console.WriteLine($"Inicio coincide en: {coincidenciaInicio} veces");
            Console.WriteLine($"Inicio coincide en: {coincidenciaFin} veces");
        }
    }
}
