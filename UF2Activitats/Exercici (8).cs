/* Autor: Joaquin Alcazar
 * M05.UF2
 * Data 27-11-2023
 * Exercici: 8
 */

using System;
using System.Numerics;

namespace M05UF2
{
    public class potWithMethod
    {
        public static void Main()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write(potWithMethod.randomNumber() + " ");
            }
        }

        public static int randomNumber()
        {
            Random r = new Random();
            return r.Next(0, 256);
        }
    }
}