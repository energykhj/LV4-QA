/* 
 * ----------------------------------------------
 * PROG2070 – Quality Assurance
 * Assignment 3
 * Heuijin Ko(8187452)
 * Created : Mar 31, 2020 
 * ----------------------------------------------
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ProjectA
{
    class Program
    {
        static void SelectMenu()
        {
            Console.WriteLine("1. Enter a number to convert");
            Console.WriteLine("2. EXit");
            Console.WriteLine();
            Console.Write("Select an option: ");
        }

        public static void GetConvertFrom()
        {
            bool bError = false;
            double convertedValue = 0;
            string convertFrom;
            string convertTo;

            do
            {
                // get a number from user
                Console.Write("\n Enter a number you'd like to convert: ");

                if (double.TryParse(Console.ReadLine(), out double value))
                {
                    // get a convertFrom
                    Console.Write(" Enter a unit you'd like to convert from: ");
                    convertFrom = Console.ReadLine();

                    Console.Write(" Enter a unit you'd like to convert to: ");
                    convertTo = Console.ReadLine();

                    try
                    {
                        convertedValue = DistanceConversion.Convert(value, convertFrom, convertTo);
                        bError = false;
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                        bError = true;
                    }

                    Console.WriteLine($"\n  Converted result>> {value} {convertFrom} = {convertedValue} {convertTo}\n");
                    Console.WriteLine($" Enter any key to continue...\n");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Error:  Enter numbers only\n");
                    bError = true;
                }
            } while (bError);
        }

        static void Main(string[] args)
        {
            bool bContinue = true;

            while (bContinue)
            {
                SelectMenu();
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        GetConvertFrom();
                        break;

                    case "2":
                        Console.WriteLine("Press Enter any key to exit the program...");
                        Console.ReadLine();
                        bContinue = false;
                        break;

                    default:
                        Console.WriteLine("Please select 1 or 2, try again.");
                        SelectMenu();
                        break;
                }
            }
        }
    }
}
