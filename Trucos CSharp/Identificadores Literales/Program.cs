using System;

namespace Identificadores_Literales
{
    class Program
    {

        public enum Categoria
        {
            FrontEnd,
            BackEnd,
            Movil,
            DevOps,
            ML
        }

        static void Main(string[] args)
        {
            //string ruta = @"D:\Archivos\UTP\VIII CICLO\INTEGRADOR I\GIT\C# Trucos\TrucosC-\Trucos CSharp\Identificador Literal\Program.cs";
            //Console.WriteLine(ruta);

            //string @if = "if(a>b){\n .. \n}";
            //Console.WriteLine(@if);

            Console.WriteLine("Bienvenido, Elija una categoría");
            var enumVals = Enum.GetValues(typeof(Categoria));
            foreach (var item in enumVals)
            {
                Console.WriteLine($"{(int)item} - {item}");
            }
            var categoria = Console.ReadLine();
            Console.WriteLine($"Respuesta: {Enum.Parse(typeof(Categoria), categoria)}");
        }
    }
}
