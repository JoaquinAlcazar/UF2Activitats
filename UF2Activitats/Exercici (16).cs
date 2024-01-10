/* Autor: Joaquin Alcazar
 * M05.UF2
 * Data 27-11-2023
 * Exercici: 16
 */

using System;
using System.Diagnostics.Metrics;
using System.Numerics;

namespace M05UF2
{
    public class productOfArray
    {
        public static void Main()
        {
            int howMany;
            int productOfTheArray = 1;

            Console.WriteLine("Quants valors vols introduir?");
            howMany = Convert.ToInt32(Console.ReadLine());
            int[] intNames = arrayCreator(howMany);


            for (int i = 0; i < intNames.Length; i++)
            {
                productOfTheArray = productCalculator(intNames[i], productOfTheArray);
            }

            Console.WriteLine($"El producte de tots el valors del array es de {productOfTheArray}");
            
        }

        public static int[] arrayCreator(int howMany)
        {
            int[] valuesToProduct = new int[howMany];
            int selectedNumber = 0;
            int counter = 0;
            while (selectedNumber > 100 || selectedNumber < 15 && counter < valuesToProduct.Length)
            {
                Console.WriteLine($"Insereix un nombre entre 15 i 100 (nombre {counter})");
                selectedNumber = Convert.ToInt32(Console.ReadLine());

                if (selectedNumber < 100 && selectedNumber > 15)
                {
                    valuesToProduct[counter] = selectedNumber;
                    counter++;
                } else
                {
                    Console.WriteLine("El nombre no está dins del rang, torna a introduirlo");
                }
            }
            return valuesToProduct;
        }

        public static int productCalculator(int toMultiply, int actualProduct)
        {
            actualProduct = actualProduct * toMultiply;
            return actualProduct;
        }
    }
}