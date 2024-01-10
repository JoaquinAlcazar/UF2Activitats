/* Autor: Joaquin Alcazar
 * M05.UF2
 * Data 27-11-2023
 * Exercici: 23
 * 
 */

using System;
using System.Diagnostics.Metrics;
using System.Numerics;

namespace M05UF2
{
    public class areaCalculator
    {
        public static void Main()
        {
            const string mainMenu = "Selecciona una forma per calcular la seva area\n" +
                "1.quadrat   2.rectangle\n" +
                "3.cercle    4.pentagon";
            int optionSelection = 0;
            float area;

            Console.WriteLine(mainMenu);
            while (optionSelection > 4 || optionSelection < 1) 
            {
                optionSelection = Convert.ToInt32(Console.ReadLine());
                if (optionSelection > 4 || optionSelection < 1) {
                    Console.WriteLine("Valor no valid, introdueix un valor valid");
                }
            }

            switch (optionSelection)
            {
                case 1:
                    area = squareCalc();
                    Console.WriteLine($"L'area del quadrat es de {area}cm quadrats");
                    break;
                case 2:
                    area = rectangleCalc();
                    Console.WriteLine($"L'area del rectangle es de {area}cm quadrats");
                    break;
                case 3:
                    area = circleCalc();
                    Console.WriteLine($"L'area del cercle es de {area}cm quadrats");
                    break;
                case 4:
                    area = pentagonCalc();
                    Console.WriteLine($"L'area del pentagon es de {area}cm quadrats");
                    break;
            }          
        }       
        
        public static float squareCalc() 
        {
            float basse;
            float height;

            Console.WriteLine("Introdueix la base en cm");
            basse = (float)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Introdueix la altura en cm");
            height = (float)Convert.ToDouble(Console.ReadLine());

            return basse * height;
        }
        public static float rectangleCalc()
        {
            float basse;
            float height;

            Console.WriteLine("Introdueix la base en cm");
            basse = (float)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Introdueix la altura en cm");
            height = (float)Convert.ToDouble(Console.ReadLine());

            return basse * height;
        }
        public static float circleCalc()
        {
            float pi = 3.1416f;
            float radius;

            Console.WriteLine("Introdueix el radi del cercle en cm");
            radius = (float)Convert.ToDouble(Console.ReadLine());

            return pi * (radius*radius);
        }
        public static float pentagonCalc()
        {
            float perimeter;
            float apothem;

            Console.WriteLine("Introdueix el perimetre en cm");
            perimeter = (float)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Introdueix l'apotema en cm");
            apothem = (float)Convert.ToDouble(Console.ReadLine());

            return (perimeter * apothem)/2;
        }
    }
}