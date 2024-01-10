/* Autor: Joaquin Alcazar
 * M05.UF2
 * Data 27-11-2023
 * Exercici: 13
 */

using System;
using System.Numerics;

namespace M05UF2
{
    public class oddPositionPrinting
    {
        public static void Main()
        {
            int[] integerNumbers = new int[20];
            

            for (int i = 0; i < integerNumbers.Length; i++)
            {
                integerNumbers[i] = oddPositionPrinting.arrayValueInjector(i);
            }

            for (int i = 1; i < integerNumbers.Length;)
            {
                oddPositionPrinting.oddPositionValue(i, integerNumbers[i]);

                i = i + 2;
            }
        }

        public static int arrayValueInjector(int i)
        {
            int selectedNumber = 0;
            Console.WriteLine("Insereix el nombre enter " + (i + 1));
            selectedNumber = Convert.ToInt32(Console.ReadLine());
            return selectedNumber;           
        }
        public static void oddPositionValue (int i, int integerNumbersI)
        {
            Console.Write(integerNumbersI + " ");
        }
    }
}