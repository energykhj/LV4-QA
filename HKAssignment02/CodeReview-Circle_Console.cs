/* 
 * ----------------------------------------------
 * PROG2070 – Quality Assurance
 * Assignment 2 - Code Review
 * Heuijin Ko(8187452)
 * Created : Feb 15, 2020 
 * ----------------------------------------------
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    /// <summary>
    /// Needs comment for a Class
    /// </summary>
    class Program
    {
        /// <summary>
        /// needs comments for a Main function
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // needs comments for the Circle Class
            Circle circle = new Circle();

            int radius = 0;
            int menuOption = 0;

            radius = GetRadiusFromUserInput(radius);

            do
            {
                // Nested looping reduces readability
                do
                {
                    // Menu options need to be separated by Method according to its purpose. 

                    // It should be considered that there may be more menu options in the future. 
                    // Exit is advantageous for future maintenance 
                    // if set to a number greater than the last menu, or set to 0.
                    // i.g.)"0. Exit" or "9. Exit"
                    Console.WriteLine("1. Get Circle Radius");
                    Console.WriteLine("2. Change Circle Radius");
                    Console.WriteLine("3. Get Circle Circumference");
                    Console.WriteLine("4. Get Circle Area");
                    Console.WriteLine("5. Exit");
                    Console.WriteLine();

                    try
                    {
                        // In another way, 
                        // if menuOption allow to get string, no need to use int.Parse.
                        // try do this:  
                        // string option = Console.ReadLine();
                        // switch(option)
                        // default: 
                        // Console.WriteLine("Please Menu select 1 to 5, try again.");
                        menuOption = int.Parse(Console.ReadLine());
                    }
                    // if use Exception, can show more detailed error messages.
                    // for example, ex.Message.
                    catch (Exception ex)
                    {
                        Console.WriteLine("Wrong option, please select from the menu:");
                        Console.WriteLine();
                    }

                    // The menu option may be more increase, 
                    // so needs a Magic Number rather than a direct number.
                    // i.g.) const int MAX_MENU_OPTION = 5
                } while (menuOption == 0 || menuOption < 0 || menuOption > 5);

                // Must be defined for the MenuOption value
                // useing case GET_RADIUS: instead of case 1: 
                // is good for readability and maintenance.
                // For example,  
                // enum menuOption
                // {
                //    GET_RADIUS = 1,
                //    CHANGE_RADIUS = 2,
                //    GET_CIRCUMFERENCE = 3,
                //    GET_CIRCLE_AREA = 4,
                //    EXIT = 0
                // }
                switch (menuOption)
                {
                    case 1:
                        radius = circle.GetRadius();
                        Console.WriteLine("the radius value is now: " + radius);
                        Console.WriteLine();
                        break;

                    case 2:
                        radius = GetRadiusFromUserInput(radius);
                        circle.SetRadius(radius);
                        Console.WriteLine("the radius value is now: " + radius);
                        Console.WriteLine();
                        break;

                    case 3:
                        Console.WriteLine("The circumference of the circle is: " + Math.Round(circle.GetCircumference(), 2));
                        Console.WriteLine();
                        break;

                    case 4:
                        Console.WriteLine("The Area of the circle is: " + Math.Round(circle.GetArea(), 2));
                        Console.WriteLine();
                        break;

                    case 5:
                        Environment.Exit(0);
                        break;
                        
                    default:
                        break;
                }

            } while (menuOption > 0 || menuOption < 5);
        }
        /// <summary>
        /// Needs Comment for the Method
        /// </summary>
        /// <param name="radius">needs comment. i.g. radius from user</param>
        /// <returns></returns>
        private static int GetRadiusFromUserInput(int radius)
        {
            do
            {
                Console.WriteLine("Please enter radius value: ");
                Console.WriteLine();

                try
                {
                    radius = int.Parse(Console.ReadLine());
                }
                // The message should be separeted depend on the exception type. 
                // This code only show one type error message, even if user enter string or decimal values.
                // if use Exception, can show more detailed error messages.
                // for example, ex.Message.
                catch (Exception ex)
                {
                    Console.WriteLine("Not the correct format, please insert a int greater than zero!");
                    Console.WriteLine();
                }

            } while (radius == 0);
            return radius;
        }


    }
}
