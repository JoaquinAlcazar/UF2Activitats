/* Autor: Joaquin Alcazar
 * M05.UF2
 * Data 27-11-2023
 * Exercici: 20
 */

using System;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Timers;

namespace M05UF2
{
    public class decimalAndInteger
    {
        public static void Main()
        {
            double number;

            Console.WriteLine("Insereix number1");
            number = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine($"La part entera de {number} es {Math.Truncate(number)} i la part decimal es {Convert.ToInt32((number - Math.Truncate(number))*100)}");
        }       
    }
}