using System;

namespace Directivas_del_preProcesador
{
    class Program
    {
        static void Main(string[] args)
        {
            //DIVIDIR CODIGO EN REGIONES
            #region Directivas

//COMO IF
#if DEBUG
            Console.WriteLine("Hello World!");
//COMO ELSE IF
#elif RELEASE
            GuardarEnBD();
            //COMO END IF
#endif

//PARA DESHABILITAR ALERTAS DE VARIABLES NO USADAS
#pragma warning disable
            var x = "Hola";

//PARA NUEVAMENTA HABILITAR ALERTAS DE VARIABLES NO USADAS
#pragma warning restore
            var x2 = "Hola";


#warning EN DESUSO
            var prueba = "dsd";


            //FINALIZAR REGION
            #endregion
        }

        public static void GuardarEnBD()
        {
            Console.WriteLine("estoy en bd");
        }
    }
}