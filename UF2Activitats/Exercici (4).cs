/* Autor: Joaquin Alcazar
 * M05.UF2
 * Data 27-11-2023
 * Exercici: 4
 */

using System;

namespace M05UF2
{
    public class Exercici4
    {
        public static void Main()
        {
            const string ask = "Vols que es mostri en majuscules o minuscules?\n1.Majuscules\n0.Minuscules";
            string selectedPhrase;
            int optionSelect;
            Console.WriteLine("Insereix un text");

            selectedPhrase = Console.ReadLine();

            Console.WriteLine(ask);
            optionSelect = Convert.ToInt32(Console.ReadLine());
            switch (optionSelect)
            {
                case 0:
                    selectedPhrase = Exercici4.toLower(selectedPhrase);
                    break;
                case 1:
                    selectedPhrase = Exercici4.toUpper(selectedPhrase);
                    break;
                default:
                    Console.WriteLine("Caracter no valid");
                    break;
            }

            Console.WriteLine("\n" + selectedPhrase);
        }

        public static string toUpper(string phrase)
        {
            return phrase.ToUpper();
        }
        public static string toLower(string phrase)
        {
            return phrase.ToLower();
        }
    }
}