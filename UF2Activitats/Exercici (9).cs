/* Autor: Joaquin Alcazar
 * M05.UF2
 * Data 27-11-2023
 * Exercici: 9
 */

using System;
using System.Numerics;

namespace M05UF2
{
    public class conditioProof
    {
        public static void Main()
        {
            int selectedNumber, minRange, maxRange, selectedNumberTwo;

            bool conditionsMet;

            Console.WriteLine("Insereix un primer nombre");
            selectedNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insereix un rang minim");
            minRange = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insereix un rang maxim");
            maxRange = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insereix un nombre dins del rang i major que el primer nombre");
            selectedNumberTwo = Convert.ToInt32(Console.ReadLine());

            conditionsMet = conditioProof.conditionTester(selectedNumber, minRange, maxRange, selectedNumberTwo);

            Console.WriteLine(conditionsMet ? $"El nombre {selectedNumber} es mes petit que {selectedNumberTwo} i es troba en el rang entre {minRange} i {maxRange}":$"El nombre {selectedNumber} no compleix alguna de les condicions (No es mes petit que {selectedNumberTwo} o no es troba al rang entre {minRange} i {maxRange})");
        }   

        public static bool conditionTester(int selectedNumber, int minRange, int maxRange, int selectedNumberTwo)
        {
            if (selectedNumber > selectedNumberTwo && selectedNumber > minRange && selectedNumber < maxRange) 
            {
                return true;
            }
            return false;
        }
    }
}