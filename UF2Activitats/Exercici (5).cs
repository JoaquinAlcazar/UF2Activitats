/* Autor: Joaquin Alcazar
 * M05.UF2
 * Data 27-11-2023
 * Exercici: 5
 */

using System;
using System.Numerics;

namespace M05UF2
{
    public class Exercici5
    {
        public static void Main()
        {
            int selectedNumber;
            bool conditionsMet;
            Console.WriteLine("Insereix un nombre");

            selectedNumber = Convert.ToInt32(Console.ReadLine());

            conditionsMet = Exercici5.conTester(selectedNumber);

            Console.WriteLine(conditionsMet ? "El nombre es menor que 100 i positiu":"El nombre es major de 100 o es negatiu");
        }

        public static bool conTester(int number)
        {
            if (number > -1 && number < 100) 
            { 
                return true;
            }
            return false;
        }
    }
}