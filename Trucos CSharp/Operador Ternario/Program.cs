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
            //autorizado = edad >= 18;

            //string mensaje = autorizado ? "Usuario autorizado" : "Usuario no autorizado";
            //Console.WriteLine(mensaje);

            //CONCATENAMOS LOS OPERADORES TERNARIOS
            string mensaje2 = edad >= 18 ? "Usuario autorizado" :
                edad >= 12 ? "Usuario con restricciones" : "Usuario no autorizado";
            Console.WriteLine(mensaje2);


            //DENTRO DEL OPERADOR SE PUEDEN REALIZAR OPERACIONES
            Console.WriteLine("Ingrese un entero");
            var num = Convert.ToInt32(Console.ReadLine());
            int op = 2;
            double resp = op == 1 ? Math.Sin(num) : Math.Cos(num);
            Console.WriteLine($"Operacion {op} de {num} = {resp}");
        }
    }
}
