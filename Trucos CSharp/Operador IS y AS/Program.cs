using System;

namespace Operador_IS_y_AS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su nombre");
            int?[] nums = new int?[] { null, null, 10, null, 100 };
            string nombre = Console.ReadLine();
            var nuevoUsuario = new UsuarioPagado { Nombre = nombre, itemsGuardados = nums };
            //PARA SABER QUE TIPO DE CLASE ES EL USUARIO ACTUAL
            if(nuevoUsuario is Usuario)
            {
                Console.WriteLine("Es usuario");
                if(nuevoUsuario is UsuarioPagado)
                    Console.WriteLine("Es usuario pagado");
                if (nuevoUsuario is Admin)
                    Console.WriteLine("Es usuario admin");

            }
        }
    }

    public class UsuarioPagado: Usuario
    {
        public int?[]itemsGuardados{ get; set; }
    }

    //Para is/as
    public class Admin : Usuario
    {
        public int?[] permisos { get; set; }
    }

    public class Proveedor
    {
        public int Agencia { get; set; }
        public int ID { get; set; }
    }

    public class Usuario
    {
        public string Nombre { get; set; }
    }
}
