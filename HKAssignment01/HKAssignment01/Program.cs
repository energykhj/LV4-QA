/* 
 * ----------------------------------------------
 * PROG2070 – Quality Assurance
 * Assignment 1
 * Heuijin Ko(8187452)
 * Created : Feb 1, 2020 
 * ----------------------------------------------
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HKAssignment01
{
    class Program
    {
        /// <summary>
        /// SeleteOption
        /// </summary>
        public static void SelectOption()
        {
            Console.WriteLine();
            Console.WriteLine("1. Get Circle Radius");
            Console.WriteLine("2. Change Circle Radius");
            Console.WriteLine("3. Get Circle Circumference");
            Console.WriteLine("4. Get Circle Area");
            Console.WriteLine("5. Exit");
            Console.WriteLine();
            Console.Write("Select an option: ");
        }
        /// <summary>
        /// Get radius from the console
        /// </summary>
        /// <returns>Radius value</returns>
        public static int GetRadius()
        {
            bool isError = false;
            int iRadius = 0;
            do
            {
                isError = false;
                Console.Write("Please enter the radius of the circle: ");

                if (int.TryParse(Console.ReadLine(), out int outRadius))
                {
                    if (outRadius <= 0)
                    {
                        Console.WriteLine("Error: Radius must be greater then 0");
                        isError = true;
                    }
                }
                else
                {
                    Console.WriteLine("Error: Radius must be integer");
                    isError = true;
                }
                Console.WriteLine();
                iRadius = outRadius;

            } while (isError);

            return iRadius;
        }
        /// <summary>
        /// main method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            bool isflag = true;
            Circle c = new Circle(GetRadius());

            while (isflag)
            {
                SelectOption();
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.WriteLine("Radiu of the circles: " + c.GetRadius());
                        break;
                    case "2":
                        c.SetRadius(GetRadius());
                        Console.WriteLine("Radius of circle has changed.");
                        break;
                    case "3":
                        Console.WriteLine("Circumference of the circle: " + c.GetCircumference());
                        break;
                    case "4":
                        Console.WriteLine("Area of the circle: " + c.GetArea());
                        break;
                    case "5":
                        Console.WriteLine("Press Enter any key to exit the program...");
                        Console.ReadLine();
                        isflag = false;
                        break;
                    default:
                        Console.WriteLine("Please select 1 to 5, try again.");
                        SelectOption();
                        break;
                }
            }
        }
    }
}
