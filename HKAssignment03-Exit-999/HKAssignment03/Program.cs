/* 
 * ----------------------------------------------
 * PROG2070 – Quality Assurance
 * Assignment 3
 * Heuijin Ko(8187452)
 * Created : Mar 30, 2020 
 * ----------------------------------------------
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HKAssignment03
{
    class Program
    {
        static void Main(string[] args)
        {
            double value = 0;
            double convertedValue = 0;

            bool bError = false;

            string convertFrom;
            string convertTo;

            while (true)
            {
               
                // get a number from user
                do
                {
                    Console.Write("\n Enter a number you'd like to convert(-999 to exit) : ");
                    try
                    {
                        value = double.Parse(Console.ReadLine());
                        if (value == -999)
                        {
                            Console.WriteLine("\nHave a great day!");
                            return;
                        }
                        bError = false;
                    }
                    catch
                    {
                        Console.WriteLine(" Error>> Enter numbers only\n");
                        bError = true;
                    }
                } while (bError);

                // get a convertFrom
                do
                {
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
                } while (bError);

                Console.WriteLine($"\n  Converted result>> {value} {convertFrom} = {convertedValue} {convertTo}\n");
                Console.WriteLine($" Enter any key to continue...\n");
                Console.ReadLine();
            }
        }
    }
}
