using System;
using System.Globalization;

namespace Tuplas
{
    class Program
    {
        static void Main(string[] args)
        {
            Tuple<string, int, int, int, DateTime>[] casosCovid = {
                Tuple.Create("Peru", 9380000,8000000, 231000, new DateTime(2020, 1, 12)),
                Tuple.Create("Brasil", 8270000,6000000, 123000, new DateTime(2020, 3, 23)),
                Tuple.Create("Argentina", 5550000,5000000, 160000, new DateTime(2020, 2, 8))
            };
            Console.WriteLine("CASOS COVID-19");
            string[] titulos = { "Pais", "Casos", "Recuperados", "Muertes", "Fecha Inicio" };
            string encabezado = string.Format("{0,-15} {1,-15} {2,-15} {3,-15} {4,-15} {5}", titulos[0], titulos[1], titulos[2], titulos[3], titulos[4], "%Recuperados");
            Console.WriteLine(encabezado);

            foreach (var caso in casosCovid)
            {
                double porcRecu = caso.Item3 / (double)caso.Item2;
                //:N0 Para indicar que es formato numerico
                //:MMMM Para indicar que es formato fecha
                //:P1 Para indicar que es formato doble
                string imprime = string.Format("{0,-15} {1,-15:N0} {2,-15:N0} {3,-15:N0} {4,-15:MMMM} {5:P1}", caso.Item1, caso.Item2, caso.Item3, caso.Item4, caso.Item5, porcRecu);
                Console.WriteLine(imprime);



                double porcRecu2 = caso.Item3 / (double)caso.Item2 *100;
                Console.WriteLine(porcRecu2.ToString("0.0"));


                CultureInfo esPE = CultureInfo.CreateSpecificCulture("es-PE");
                Console.WriteLine(caso.Item2.ToString("0.0", esPE));


                string msj = string.Format("#0.##%" + (porcRecu > 0.8 ? "Bueno" : "Malo"), porcRecu);

                Console.WriteLine(porcRecu.ToString(msj));


                long telefono = 151941917926;
                Console.WriteLine(telefono.ToString("+# (##) ###-###-###"));
            }
        }
    }
}
