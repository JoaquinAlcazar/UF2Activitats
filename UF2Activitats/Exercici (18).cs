/* Autor: Joaquin Alcazar
 * M05.UF2
 * Data 27-11-2023
 * Exercici: 18
 */

using System;
using System.Diagnostics.Metrics;
using System.Numerics;

namespace M05UF2
{
    public class minutesToSecondsCalc
    {
        public static void Main()
        {
            int minutes;
            int convertedMinutes = 0;

            Console.WriteLine("Insereix una quantitat de minuts");           
            minutes = Convert.ToInt32(Console.ReadLine());
            convertedMinutes = minutesConverter(minutes);
            Console.WriteLine($"{minutes} minuts es equivalent a {convertedMinutes} segons");
        }

        public static int minutesConverter(int minutes)
        {            
            return (minutes * 60);
        }
    }
}