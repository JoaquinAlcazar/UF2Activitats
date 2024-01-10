/* Autor: Joaquin Alcazar
 * M05.UF2
 * Data 27-11-2023
 * Exercici: 7
 */

using System;
using System.Numerics;

namespace M05UF2
{
    public class potWithMethod
    {
        public static void Main()
        {
            double numBase, numExp, numPot;

            Console.WriteLine("Introdueix la base");
            numBase = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Introdueix l'exponent");
            numExp = Convert.ToDouble(Console.ReadLine());

            numPot = potWithMethod.power(numBase, numExp);
            Console.WriteLine($"La potencia de la base {numBase} i exponent de {numExp} es {numPot}");
        }

        public static double power(double basse, double exponent)
        {

            return Math.Pow(Convert.ToDouble(basse), Convert.ToDouble(exponent));
        }
    }
}