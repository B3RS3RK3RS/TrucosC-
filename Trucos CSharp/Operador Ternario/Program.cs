using System;

//SINTAXIS:
// condicion ? expresion A : expresion B
namespace Operador_Ternario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una edad");
            int edad = Convert.ToInt32(Console.ReadLine());
            bool autorizado = false;
            /* if (edad >= 18)
                 autorizado = true;
             else
                 autorizado = false;*/

            //autorizado = edad >= 18 ? true : false;
            autorizado = edad >= 18;

            string mensaje = autorizado ? "Usuario autorizado" : "Usuario no autorizado";
            Console.WriteLine(mensaje);
        }
    }
}
