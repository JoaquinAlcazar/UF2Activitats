/* Autor: Joaquin Alcazar
 * M05.UF2
 * Data 27-11-2023
 * Exercici: 11
 */

using System;
using System.Numerics;

namespace M05UF2
{
    public class aquaService
    {
        public static void Main()
        {
            int litreCount;
            double totalPrice;

            Console.WriteLine("Cuants llitres has consumit aquest mes?");
            litreCount = Convert.ToInt32(Console.ReadLine());

            totalPrice = aquaService.priceCalculator(litreCount);

            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine($"El total a pagar son {totalPrice}€");
        }

        public static double priceCalculator (int consumedWater)
        {
            const double fixedQuota = 6.0;
            double totalPrice = 0;
            int difference = 0;

            if (consumedWater <= 50)
            {
                return fixedQuota;
            } else if (consumedWater > 50 && consumedWater <=200)
            {
                difference = consumedWater - 50;
                totalPrice = fixedQuota + (0.1 * difference);
                return totalPrice;
            }
            else
            {
                difference = consumedWater - 200;
                totalPrice = fixedQuota + (0.1 * 150) + (0.3 * difference);
                return totalPrice;
            }
            return fixedQuota;
        }
    }
}