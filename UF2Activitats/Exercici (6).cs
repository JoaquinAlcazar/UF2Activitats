/* Autor: Joaquin Alcazar
 * M05.UF2
 * Data 27-11-2023
 * Exercici: 6
 */

using System;
using System.Numerics;

namespace M05UF2
{
    public class Exercici6
    {
        public static void Main()
        {
            int selectedNumber, finalNumber;

            Console.WriteLine("Inserta un nombre.");
            selectedNumber = Convert.ToInt32(Console.ReadLine());
            finalNumber = absolute(selectedNumber);

            Console.WriteLine($"El nombre absolut de {selectedNumber} es {finalNumber}");
        }

        public static int absolute(int number)
        {
            number = Math.Abs(number);
            return number;
        }
    }
}