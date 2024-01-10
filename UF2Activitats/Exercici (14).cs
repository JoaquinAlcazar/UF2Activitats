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
    public class calculusWithANumber
    {
        public static void Main()
        {
            int selectedNumber;

            Console.WriteLine("Insereix un nombre enter");
            selectedNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"El nombre {selectedNumber} te {quantityNumbersCalculator(selectedNumber)} xifres, dels cuals la suma de nombres parells es de {evenNumbersSum(selectedNumber)}" +
                $" i la suma de nombres senars es de {oddNumbersSum(selectedNumber)}");
        }

        public static int quantityNumbersCalculator(int selectedNumber)
        {
            int counter = 0;
            while ( selectedNumber > 0 ) 
            {
                selectedNumber = selectedNumber / 10;
                counter++;
            }
            return counter;
        }
        public static int evenNumbersSum(int selectedNumber)
        {
            int total = 0;
            int selectedForNumber;
            while (selectedNumber > 0)
            {
                selectedForNumber = selectedNumber%10;
                selectedNumber = selectedNumber / 10;
                if ( selectedForNumber%2 == 0 ) 
                {
                    total += selectedForNumber; 
                }
            }
            return total;
        }

        public static int oddNumbersSum(int selectedNumber)
        {
            int total = 0;
            int selectedForNumber;
            while (selectedNumber > 0)
            {
                selectedForNumber = selectedNumber % 10;
                selectedNumber = selectedNumber / 10;
                if (selectedForNumber % 2 != 0)
                {
                    total += selectedForNumber;
                }
            }
            return total;
        }
    }
}