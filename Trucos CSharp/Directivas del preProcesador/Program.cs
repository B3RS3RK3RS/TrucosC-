//DEFINIR DIRECTIVAS PERSONALIZADAS PARA ESTE ARCHIVO .cs
#define LogDT     
using System;
using System.Diagnostics;

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
#if LogDT
            Console.WriteLine($"Hora y fecha: {DateTime.Now}");
#endif

            //DEFINIENDO VARIABLES ENVIRONMENT
            Console.WriteLine($"Stack Trace: {Environment.StackTrace}");
            Console.WriteLine($"Directorio actual: {Environment.CurrentDirectory}");
            Console.WriteLine($"Usuarui actual: {Environment.UserName}");
            Console.WriteLine($"Maquina actual: {Environment.MachineName}");
            Console.WriteLine($"Version OS: {Environment.OSVersion}");
            Console.WriteLine($"Directorio VS: {Environment.GetEnvironmentVariable("VisualStudioDir")}");

            //Variables de ENTORNO
            var VarsEntorno = Environment.GetEnvironmentVariables();
        }

        [Conditional("LOG")]
        public static void GuardarEnBD()
        {
            Console.WriteLine("estoy en bd");
        }
    }
}