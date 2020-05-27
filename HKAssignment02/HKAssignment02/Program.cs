/* 
 * ----------------------------------------------
 * PROG2070 – Quality Assurance
 * Assignment 2
 * Heuijin Ko(8187452)
 * Created : Feb 15, 2020 
 * ----------------------------------------------
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HKAssignment02
{
    class Program
    {
        static void SelectMenu()
        {
            Console.WriteLine("1. Enter triangle dimensions");
            Console.WriteLine("2. EXit");
            Console.WriteLine();
            Console.Write("Select an option: ");
        }

        static int[] GetTriangleDemensions()
        {
            bool bFlag = true;
            int[] demension = new int[3];
            int i = 0;
            Console.WriteLine("\n\nPlease enter three integers");

            while (i < 3)
            {               
                do
                {
                    
                    try
                    {
                        Console.Write($"Enter demension {i+1} : ");
                        demension[i] = int.Parse(Console.ReadLine());
                        bFlag = true;

                        if (demension[i] <= 0)
                        {
                            Console.WriteLine("\nError: Dimension  must be greater than 0");
                            bFlag = false;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"\nError: {ex.Message} \nEnter only integer, please try again.\n");
                        bFlag = false;
                    }
                } while (!bFlag);

                i++;
            }
            
            return demension;
        }

        static void Main(string[] args)
        {
            bool bFlag = true;            

            while (bFlag)
            {
                SelectMenu();
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.WriteLine(TriangleSolver.Analyze(GetTriangleDemensions()));
                        break;

                    case "2":
                        Console.WriteLine("Press Enter any key to exit the program...");
                        Console.ReadLine();
                        bFlag = false;
                        break;
                    default:
                        Console.WriteLine("Please select 1 or 2, try again.\n");
                        break;
                }
            }
        }
    }
}
