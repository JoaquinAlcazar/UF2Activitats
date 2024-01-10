/* Autor: Joaquin Alcazar
 * M03 - UF2: Disseny modular
 * Exercici 1
 */

using System;

namespace UF2
{

    class UF2Exercici1
    {

        public static void Main()
        {
            // no hace falta declarar variables
            bool isNatural1 = false;
            bool isNatural2 = false;
            Console.WriteLine("Introdueix un nombre natural");
            int selectedNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(""); // pon "\n" al principio del siguiente writeline

            Console.WriteLine("Introdueix un altre nombre natural");
            int selectedNumber2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            // sobra, lo puedes poner en el writeline
            isNatural1 = UF2Exercici1.IsItNatural(selectedNumber);
            isNatural2 = UF2Exercici1.IsItNatural(selectedNumber2);
                
            // bien mas o menos
            Console.WriteLine(isNatural1 ? $"{selectedNumber} es un nombre natural\n" : $"{selectedNumber} no es nombre natural\n");
            Console.WriteLine(isNatural2 ? $"{selectedNumber2} es un nombre natural" : $"{selectedNumber2} no es nombre natural");
            // suerte!!!!! <3
        }

        public static bool IsItNatural(int selNumber)
        {
            // (solo necesitas la condicional sin un if)
            if (selNumber > 0) return true;
            return false;
        }
    }
}