using System;

namespace recursivitatExercicis
{
    public class exercici26
    {
        public static void Main(string[] args)
        {
            int input;
            int result;

            Console.WriteLine("Insereix nombre");
            input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"La suma dels digits de {input} es {calcSum(input)}");
        }

        public static int calcSum(int num)
        {
            int answer = 0;
            int numForModule = num % 10;
            if (num == 0) return 0;
            else
            {
                answer = numForModule + calcSum(num/10);
            }
            return answer;
        }
    }

    
}
