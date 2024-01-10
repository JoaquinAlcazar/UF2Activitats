/* Autor: Joaquin Alcazar
 * M05.UF2
 * Data 14-11-2023
 * Exercici: 3
 */

using System;

namespace M05UF2
{
    public class Exercici3
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
            if (number < 0) 
            {
                number = number * -1;
                return number;
            }
            return number;
        }
    }
}