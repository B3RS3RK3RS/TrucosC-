using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

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

        public class Curso
        {
            public string _titulo { get; set; }
            public Categoria _categoria { get; set; }
            public SubCat _subcategoria { get; set; }
            public int _capitulos { get; set; }
        }

        public class Capitulo
        {
            public string _id { get; set; }
            public string _titulo { get; set; }
            public string _descripcion { get; set; }
            public Curso _curso { get; set; }
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
            //var enumVals = Enum.GetValues(typeof(Categoria));
            //var imprime = EnumNombOpc(enumVals);
            //foreach (var item in imprime)
            //{
            //    Console.WriteLine(item); //PASO 2
            //}
            #endregion
            #region Combinacion de Enumerable
            //var enumVals = Enum.GetValues(typeof(Categoria));
            //var imprime = EnumNombOpc(enumVals);
            //var enumValsB = Enum.GetValues(typeof(Busqueda));
            //var imprimeB = EnumNombOpc(enumValsB);

            //IEnumerable<string> todasOpc = imprime.Concat(imprimeB);

            //foreach (var item in todasOpc)
            //{
            //    Console.WriteLine(item);
            //}

            Curso CursoA = new Curso
            {
                _titulo = "Trucos c#",
                _categoria = Categoria.BackEnd,
                _subcategoria = SubCat.Csharp,
                _capitulos = 5
            };

            Capitulo CapituloA = new Capitulo
            {
                _id = "CapA01",
                _titulo = "Capitulo 1",
                _descripcion = "Descripcion 1",
                _curso = CursoA
            };

            Capitulo CapituloB = new Capitulo
            {
                _id = "CapB01",
                _titulo = "Capitulo 2",
                _descripcion = "Descripcion 2",
                _curso = CursoA
            };

            List<Curso> lstCursos = new List<Curso> { CursoA };
            List<Capitulo> lstCapitulo = new List<Capitulo> { CapituloA, CapituloB };

            var union = lstCursos.Join(lstCapitulo,
                curso => curso, 
                cap => cap._curso,
                (_curso, _cap) => new
                {
                    CursoTitulo = _curso._titulo,
                    CursoCapitulo = _cap._titulo,
                    CapituloDescripcion = _cap._descripcion
                });

            foreach (var item in union)
            {
                Console.WriteLine(item);
            }

            #endregion
        }

        public static IEnumerable<string> EnumNombOpc (Array enumVals)
        {
            foreach (var item in enumVals)
            {
                string opc = $"{(int)item} - {item}";   //PASO 1
                yield return opc;
                //Console.WriteLine("Libero memoria");    //PASO 3
            }
        }
    }
}
