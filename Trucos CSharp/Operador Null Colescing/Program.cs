using System;
using System.Linq;

namespace Operador_Null_Colescing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int? x = null;  //DECLARAMOS X COMO NULO (los int no pueden ser nulo, pero cambiamos la condicion al colocar ?)
            int nuevo = x ?? 0; //Asignamos un valor de 0 a nuevo si "x" es nulo

            int?[] nums = new int?[] { 1, null, null };
            int suma = nums.Sum() ?? 0;
            Console.WriteLine($"La suma es: {suma}");
        }
    }
}
