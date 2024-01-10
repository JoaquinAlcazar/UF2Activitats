/* Autor: Joaquin Alcazar
 * M05.UF2
 * Data 27-11-2023
 * Exercici: 21
 */

using System;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Timers;

namespace M05UF2
{
    public class romanNumberConverter
    {
        public static void Main()
        {
            string romanNumber;

            Console.WriteLine("Introdueix un numero en nombres romans");
            romanNumber = Console.ReadLine();
            romanNumber = romanNumber.ToUpper();

            int convertedRomanNumber = romanNumberCalculator(romanNumber);

            if (convertedRomanNumber == 0)
            {
                Console.WriteLine("S'han repetit més de 3 vegades una xifra");
            } else if (convertedRomanNumber == -1)
            {
                Console.WriteLine("Has intentat restar una xifra amb una xifra incorrecte");
            } else if (convertedRomanNumber == -2)
            {
                Console.WriteLine("No pots restar V/L/D a altres xifres");
            } else if (convertedRomanNumber == -3)
            {
                Console.WriteLine("El nombre está malament escrit");
            }
            else
            {
                Console.WriteLine($"El nombre romá {romanNumber} correspon al nombre decimal {convertedRomanNumber}");
            }
        }       

        public static int romanNumberCalculator(string romanNumber) 
        {
            int result = 0;
            int iCounter = 0;
            int vCounter = 0;
            int xCounter = 0;
            int lCounter = 0;
            int cCounter = 0;
            int dCounter = 0;
            int mCounter = 0;

            for (int i = 0; i < romanNumber.Length-1; i++)
            {
                if (i > 1)
                {
                    switch (romanNumber[i])
                    {
                        case 'I':
                            if (romanNumber[i - 2] == 'I' && romanNumber[i-1] != 'I')
                            {
                                return -3;
                            }
                            break;
                        case 'V':
                            if (romanNumber[i - 2] == 'I' || romanNumber[i - 2] == 'V')
                            {
                                return -3;
                            }
                            break;
                    }
                }
                switch (romanNumber[i])
                {
                    case 'I':
                        if (romanNumber[i + 1] == 'X' || romanNumber[i+1] == 'V')
                        {
                            result -= 1;
                        } 
                        else if (romanNumber[i + 1] == 'L' || romanNumber[i + 1] == 'M' || romanNumber[i + 1] == 'C' || romanNumber[i + 1] == 'D')
                        {
                            return -1;
                        }
                        else
                        {
                            result += 1;
                        }
                        iCounter++;
                        break;
                    case 'V':
                        if (romanNumber[i + 1] != 'I')
                        {
                            return -2;
                        }
                        result += 5;
                        vCounter++;
                        break;
                    case 'X':
                        if (romanNumber[i + 1] == 'L' || romanNumber[i + 1] == 'C')
                        {
                            result -= 10;
                        }else
                        {
                            result += 10;
                        }
                        xCounter++;
                        break;
                    case 'L':
                        if (romanNumber[i + 1] != 'I' || romanNumber[i + 1] != 'V' || romanNumber[i + 1] != 'X')
                        {
                            return -2;
                        }
                        result += 50;
                        lCounter++;
                        break;
                    case 'C':
                        if (romanNumber[i + 1] == 'D' || romanNumber[i + 1] == 'M')
                        {
                            result -= 100;
                        }else
                        {
                            result += 100;
                        }
                        cCounter++;
                        break;
                    case 'D':
                        if (romanNumber[i + 1] != 'I' || romanNumber[i + 1] != 'V' || romanNumber[i + 1] != 'X' || romanNumber[i + 1] != 'L' || romanNumber[i + 1] != 'C' || romanNumber[i + 1] != 'D')
                        {
                            return -2;
                        }
                        result += 500;
                        dCounter++;
                        break;
                    case 'M':
                        result += 1000;
                        mCounter++;
                        break;
                }            
            }
            switch (romanNumber[romanNumber.Length-1])
            {
                case 'I':
                    if (romanNumber[(romanNumber.Length - 1) - 2] == 'I' && romanNumber[(romanNumber.Length - 1) - 1] != 'I')
                    {
                        return -3;
                    }
                    result += 1;
                    iCounter++;
                    break;
                case 'V':
                    if (romanNumber[(romanNumber.Length - 1) - 2] == 'I' || romanNumber[(romanNumber.Length - 1) - 2] == 'V')
                    {
                        return -3;
                    }
                    result += 5;
                    vCounter++;
                    break;
                case 'X':
                    result += 10;
                    xCounter++;
                    break;
                case 'L':
                    result += 50;
                    lCounter++;
                    break;
                case 'C':
                    result += 100;
                    cCounter++;
                    break;
                case 'D':
                    result += 500;
                    dCounter++;
                    break;
                case 'M':
                    result += 1000;
                    mCounter++;
                    break;
            }
            
            if (iCounter > 3 || vCounter > 3 || xCounter > 3 || lCounter > 3 || cCounter > 3 || dCounter > 3 || mCounter > 3)
            {
                return 0;
            }
            return result;
        }
    }
}