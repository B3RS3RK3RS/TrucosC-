using System;
using System.Collections;
using System.Collections.Generic;

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

        public enum SubCat : byte
        {
            Vue = 1,
            React = 2,
            Csharp = 11,
            Java = 12
        }

        [Flags]
        public enum Busqueda
        {
            Ninguno = 1,
            Categoria = 2,
            SubCategoria = 3,
            Reciente = 4,
            Todos = 5
        }

        static void Main(string[] args)
        {
            #region @
            //string ruta = @"D:\Archivos\UTP\VIII CICLO\INTEGRADOR I\GIT\C# Trucos\TrucosC-\Trucos CSharp\Identificador Literal\Program.cs";
            //Console.WriteLine(ruta);

            //string @if = "if(a>b){\n .. \n}";
            //Console.WriteLine(@if);
            #endregion
            #region enum
            //Console.WriteLine("Bienvenido, Elija una categoría");
            //var enumVals = Enum.GetValues(typeof(Categoria));
            //foreach (var item in enumVals)
            //{
            //    Console.WriteLine($"{(int)item} - {item}");
            //}
            //var categoria = Console.ReadLine();
            //Console.WriteLine($"Respuesta: {Enum.Parse(typeof(Categoria), categoria)}");
            #endregion
            #region flag
            //var val = Busqueda.Categoria | Busqueda.Reciente | Busqueda.Ninguno; //Asigna valor de "Categoria,Reciente"
            //Console.WriteLine(val.ToString());

            //if (val.HasFlag(Busqueda.Ninguno))
            //    Console.WriteLine("Incluye Ninguno");
            //if (val.HasFlag(Busqueda.Reciente))
            //    Console.WriteLine("Incluye Reciente");
            //if (val.HasFlag(Busqueda.Categoria))
            //    Console.WriteLine("Incluye Categoria");
            #endregion
            #region Yield
            var enumVals = Enum.GetValues(typeof(Categoria));
            var imprime = EnumNombOpc(enumVals);
            foreach (var item in imprime)
            {
                Console.WriteLine(item); //PASO 2
            }
            #endregion
        }

        public static IEnumerable<string> EnumNombOpc (Array enumVals)
        {
            foreach (var item in enumVals)
            {
                string opc = $"{(int)item} - {item}";   //PASO 1
                yield return opc;
                Console.WriteLine("Libero memoria");    //PASO 3
            }
        }
    }
}
