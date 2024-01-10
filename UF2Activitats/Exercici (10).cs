/* Autor: Joaquin Alcazar
 * M05.UF2
 * Data 27-11-2023
 * Exercici: 10
 */

using System;
using System.Diagnostics.Metrics;
using System.Numerics;

namespace M05UF2
{
    public class searchInRandomNumbers
    {
        public static void Main()
        {
            int[] randomNumbers = new int[10];

            int selectedNumber;

            bool found = false;

            int counter = 0;

            for (int i = 0; i < 10; i++)
            {
                randomNumbers[i] = searchInRandomNumbers.randomGenerator();
            }

            Console.WriteLine("Guia:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(randomNumbers[i] + " ");
            }

            Console.WriteLine("\nInserta un valor que es trobi entre els numeros generats aleatoriament");
            selectedNumber = Convert.ToInt32(Console.ReadLine());

            while (!found && counter < randomNumbers.Length)
            {
                found = searchInRandomNumbers.arraySearcher(selectedNumber, randomNumbers[counter]);
                counter++;
            }
            
            Console.WriteLine(found ? $"El nombre {selectedNumber} es troba entre els nombres generats": $"El nombre {selectedNumber} no es troba entre els nombres generats");
        }   

        public static int randomGenerator()
        {
            Random random = new Random();
            return random.Next(0, 200);
        }

        public static bool arraySearcher(int selectedNumber, int comparatorNumber)
        {
            if (selectedNumber == comparatorNumber)
            {
                return true;
            }
            return false;
        }
    }
}