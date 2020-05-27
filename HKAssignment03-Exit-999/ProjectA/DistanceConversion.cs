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
    public static class DistanceConversion
    {
        public static double Convert(double value, string convertFrom, string convertTo)
        {
            return value * GetMultiplierStub(ModifyInputStub(convertFrom), ModifyInputStub(convertTo));
        }

        private static string ModifyInputStub(string input)
        {
            return "meters";
        }

        private static double GetMultiplierStub(string convertFrom, string convertTo)
        {
            return 3d;
        }
    }
}
