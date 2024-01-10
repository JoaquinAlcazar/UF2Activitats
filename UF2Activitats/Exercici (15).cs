/* Autor: Joaquin Alcazar
 * M05.UF2
 * Data 27-11-2023
 * Exercici: 14
 */

using System;
using System.Diagnostics.Metrics;
using System.Numerics;

namespace M05UF2
{
    public class leapYearCalculation
    {
        public static void Main()
        {
            bool isLeap;
            int selectedYear = 0;

            Console.WriteLine("Introdueix un any");
            selectedYear = Convert.ToInt32(Console.ReadLine());

            isLeap = leapYearCalculation.isLeapYear(selectedYear);

            Console.WriteLine(isLeap ? $"L'any {selectedYear} es un any de trespás.": $"L'any {selectedYear} no es un any de trespás.");
        }

        public static bool isLeapYear(int selectedNumber)
        {
            if (selectedNumber%4 == 0)
            {
                return true;
            }
            return false;
        }
    }
}