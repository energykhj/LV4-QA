/* 
 * ----------------------------------------------
 * PROG2070 – Quality Assurance
 * Assignment 3
 * Heuijin Ko(8187452)
 * Created : Mar 29, 2020 
 * ----------------------------------------------
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HKAssignment03
{
    public static class DistanceConversion
    {
        /// <summary>
        /// Makes exact word of the convert unit and take multiplier accordingly 
        /// </summary>
        /// <param name="value">multiplier</param>
        /// <param name="convertFrom"></param>
        /// <param name="convertTo"></param>
        /// <returns>multiplier</returns>
        public static double Convert(double value, string convertFrom, string convertTo)
        {
            return value * GetMultiplier(ModifyInput(convertFrom), ModifyInput(convertTo));
        }

        /// <summary>
        /// Makes exact word of the convert unit
        /// </summary>
        /// <param name="input"></param>
        /// <returns>convert unit</returns>
        private static string ModifyInput(string input)
        {
            string unit = "";
            string[] lstMeterUnits = { "meters", "Meters", "m", "M" };
            string[] lstYardUnits = { "yards", "Yards", "y", "Y" };
            string[] lstFeetUnits = { "feet", "Feet", "f", "F" };
            string[] lstRodsUnits = { "rods", "Rods", "r", "R" };

            if (lstMeterUnits.Contains(input)) return unit = "meters";
            else if (lstYardUnits.Contains(input)) return unit = "yards";
            else if (lstFeetUnits.Contains(input)) return unit = "feet";
            else if (lstRodsUnits.Contains(input)) return unit = "rods";
            else throw new ArgumentException(" Error>> Enter unit one of only meters, feet, yards, or rods\n");
        }
        /// <summary>
        /// Takes multiplier according t convert unit
        /// </summary>
        /// <param name="convertFrom"></param>
        /// <param name="convertTo"></param>
        /// <returns></returns>
        private static double GetMultiplier(string convertFrom, string convertTo)
        {
            double multiplier = 0d;
            switch (convertFrom)
            {
                case "meters":
                    switch (convertTo)
                    {
                        case "meters":
                            multiplier = 1d;
                            break;
                        case "feet":
                            multiplier = 3.28084d;
                            break;
                        case "rods":
                            multiplier = 0.19883d;
                            break;
                        case "yards":
                            multiplier = 1.09361d;
                            break;
                        default:
                            break;
                    }
                    break;
                case "yards":
                    switch (convertTo)
                    {
                        case "meters":
                            multiplier = 0.9144d;
                            break;
                        case "feet":
                            multiplier = 3d;
                            break;
                        case "rods":
                            multiplier = 0.181818d;
                            break;
                        case "yards":
                            multiplier = 1d;
                            break;
                        default:
                            break;
                    }
                    break;
                case "feet":
                    switch (convertTo)
                    {
                        case "meters":
                            multiplier = 0.3048d;
                            break;
                        case "feet":
                            multiplier = 1d;
                            break;
                        case "rods":
                            multiplier = 0.0606061d;
                            break;
                        case "yards":
                            multiplier = 0.333333d;
                            break;
                        default:
                            break;
                    }
                    break;
                case "rods":
                    switch (convertTo)
                    {
                        case "meters":
                            multiplier = 5.0292d;
                            break;
                        case "feet":
                            multiplier = 16.5d;
                            break;
                        case "rods":
                            multiplier = 1d;
                            break;
                        case "yards":
                            multiplier = 5.5d;
                            break;
                        default:
                            break;
                    }
                    break;

                default:
                    break;
            }
            return multiplier;
        }
    }
}
