/* Autor: Joaquin Alcazar
 * M05.UF2
 * Data 27-11-2023
 * Exercici: 11
 */

using System;
using System.Numerics;

namespace M05UF2
{
    public class factorialNumber
    {
        public static void Main()
        {
            int selectedNumber, factorialNumber;

            Console.WriteLine("Insereix un nombre per obtenir el seu factorial");
            selectedNumber = Convert.ToInt32(Console.ReadLine());

            factorialNumber = factorialMaker(selectedNumber);

            Console.WriteLine($"El factorial de {selectedNumber} es {factorialNumber}");

        }   

        public static int factorialMaker(int selectedNumber)
        {
            int madeFactorial = 1;
            for (int i = 1; i <= selectedNumber; i++)
            {
                madeFactorial *= i;
            }
            return madeFactorial;
            
        }
    }
}