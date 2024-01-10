using System;
using System.Diagnostics.Metrics;

namespace recursivitatExercicis
{
    public class exercici26
    {
        public static void Main(string[] args)
        {
            int input;

            Console.WriteLine("Insereix nombre");
            input = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insereix nombre 2");
            int inputB = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(russianMult(input, inputB));
            
        }

        public static int russianMult(int num, int numB)
        {
            int answerForOdd = 0;
            if (num % 2 == 0) 
            {
                while (num != 1)
                {
                    num /= 2;
                    numB *= 2;
                }

                return numB;
            }
            else
            {
                while (num != 1)
                {
                    num /= 2;
                    numB *= 2;
                    if (num % 2 != 0)
                    {
                        answerForOdd += numB;
                    }
                    
                }

                return numB;
            }
            
        }
    }

    
}
