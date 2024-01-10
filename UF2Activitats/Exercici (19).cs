/* Autor: Joaquin Alcazar
 * M05.UF2
 * Data 27-11-2023
 * Exercici: 18
 */

using System;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Timers;

namespace M05UF2
{
    public class maxMinMathLibrary
    {
        public static void Main()
        {
            int number1, number2;

            Console.WriteLine("Insereix number1");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insereix number2");
            number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"El nombre mes gran es {Math.Max(number1, number2)} i el mes petit es {Math.Min(number1, number2)}");
        }

        
    }
}