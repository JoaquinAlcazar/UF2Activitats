/* Autor: Joaquin Alcazar
 * M05.UF2
 * Data 27-11-2023
 * Exercici: 17
 */

using System;
using System.Diagnostics.Metrics;
using System.Numerics;

namespace M05UF2
{
    public class celsiusToFarenheitConverter
    {
        public static void Main()
        {
            double celsius;
            double farenheit;

            Console.WriteLine("Insereix els graus celsius");
            celsius = Convert.ToSingle(Console.ReadLine());


            farenheit = converter(celsius);
            farenheit = Convert.ToDouble(decimal.Round(Convert.ToDecimal(farenheit)));
            Console.WriteLine($"Graus celcius: {celsius}.\nGraus farenheit: {farenheit}.");
        }

        public static double converter(double celsius)
        {
            double farenheitGrades = ((celsius * 9) / 5) + 32;
            return farenheitGrades;
        }

        
    }
}