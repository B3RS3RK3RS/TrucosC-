using System;
using System.Diagnostics;
using System.Text;

namespace Construccion_de_Cadenas
{
    class Program
    {
        static void Main(string[] args)
        {
            string mensaje = "Hola mundo";
            mensaje = "hola nuevamente mundo";


            StringBuilder sb = new StringBuilder("Hola Mundo");
            StringBuilder sb2 = new StringBuilder(5, 5); //CAPACIDAD, CAPACIDAD MAXIMA
            //sb2.Append(sb);


            //Comparacion entre string y StringBuilder
            Stopwatch sw = new Stopwatch();
            int ciclos = 50000;

            string str = "";
            sw.Start();
            for (int i = 0; i < ciclos; i++)
            {
                str +=i.ToString();
            }
            sw.Stop();
            Console.WriteLine($"TIEMPO DE STRING EN MILISEGUNDOS {sw.ElapsedMilliseconds}");


            StringBuilder sw3 = new StringBuilder();
            sw.Restart();
            for (int i = 0; i < ciclos; i++)
            {
                sw3.Append(i.ToString());
            }
            sw.Stop();
            Console.WriteLine($"TIEMPO DE STRINGBUILDER EN MILISEGUNDOS {sw.ElapsedMilliseconds}");
        }
    }
}