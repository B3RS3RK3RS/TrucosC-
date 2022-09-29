using System;

namespace Operador_de_condición_nula
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int?[] nums = new int?[] { null, null, 10, null, 100 };
            string mensaje;
            int? item = nums[2];
            mensaje = item == null ? "No se encuentra entero" : item.ToString();
            Console.WriteLine(mensaje);

            var mensaje2 = item?.ToString() ?? "item nulo";
            Console.WriteLine(mensaje2);
        }
    }
}
