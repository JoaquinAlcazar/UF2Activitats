using System;

namespace recursivitatExercicis
{
    public class exercici26
    {
        public static void Main(string[] args)
        {
            int input;

            Console.WriteLine("Insereix nombre");
            input = Convert.ToInt32(Console.ReadLine());
            int trueInput = input;
            if (natAndPrime(input, trueInput)) 
            {
                Console.WriteLine("Es natural i primer");
            }
            else
            {
                Console.WriteLine("No es Natural i/o primer");
            }
            
        }

        public static bool natAndPrime(int num, int trueNum)
        {   
            if (trueNum < 1) return false;
            int numToCalc = num - 1;
            if (numToCalc == 1) return true;
            if (trueNum%numToCalc == 0) return false;
            else
            {
                return natAndPrime(numToCalc, trueNum);
            }
        }
    }

    
}
