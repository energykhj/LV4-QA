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
    /// <summary>
    /// A class TriangleSolver
    /// </summary>
    public static class TriangleSolver
    {
        /// <summary>
        /// Check triangle
        /// </summary>
        /// <param name="threeDemensions">3 sides for the triangle</param>
        /// <returns>analyzed result </returns>
        public static string Analyze(int[] threeDemensions)
        {
            return FormTriangle(threeDemensions)? 
                KindOfTriangle(threeDemensions) : 
                "These numbers can not be triangle";
        }
        /// <summary>
        /// Check if the numbers entered can form a triangle
        /// </summary>
        /// <param name="demensions">3 sides for the triangle</param>
        /// <returns>if can be a triangle, true</returns>
        private static bool FormTriangle(int[] demensions)
        {
            return
            (demensions[0] + demensions[1] > demensions[2] &&
            demensions[0] + demensions[2] > demensions[1] &&
            demensions[1] + demensions[2] > demensions[0]) ? true : false;
        }
        /// <summary>
        /// Analysis kind of triangle
        /// </summary>
        /// <param name="demensions">3 sides for the triangle</param>
        /// <returns>analyzed result</returns>
        private static string KindOfTriangle(int[] demensions)
        {
            // all sides are different
            if (demensions[0] != demensions[1] &&
                demensions[1] != demensions[2] &&
                demensions[2] != demensions[0])
                return "It can be a Scalene triangle";

            // all three sides are equal
            else if (demensions[0] == demensions[1] &&
                demensions[1] == demensions[2])
                return "It can be an Equilateral triangle";

            // two sides are equal
            else 
                return "It can be an Isosceles triangle";

        }
    }
}
