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

namespace ProjectB
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
            return value * GetMultiplierStub(ModifyInput(convertFrom), ModifyInput(convertTo));
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

        private static double GetMultiplierStub(string convertFrom, string convertTo)
        {
            return 3d;
        }
    }
}
