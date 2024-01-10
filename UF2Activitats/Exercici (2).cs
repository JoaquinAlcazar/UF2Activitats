/* Autor: Joaquin Alcazar
 * M05.UF2
 * Data 14-11-2023
 * Exercici: 2
 */

using System;

namespace M05UF2
{
    public class Exercici2
    {
        public static void Main()
        {
            int numBase, numExp, numPot;

            Console.WriteLine("Introdueix la base");
            numBase = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introdueix l'exponent");
            numExp = Convert.ToInt32(Console.ReadLine());

            numPot = Exercici2.power(numBase, numExp);
            Console.WriteLine($"La potencia de la base {numBase} i exponent de {numExp} es {numPot}");
        }

        public static int power(int basse, int exponent)
        {
            int returner = basse;
            int counter = 1;
            while (counter < exponent)
            {
                returner = returner * exponent;
                counter++;
            }
            return returner;
        }
    }
}