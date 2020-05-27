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
    /// <summary>
    /// Circle class
    /// </summary>
    public class Circle
    {
        private int radius;

        /// <summary>
        /// Default constructor
        /// </summary>
        public Circle()
        {
            radius = 1;
        }
        /// <summary>
        /// non default constructor
        /// </summary>
        /// <param name="radius"></param>
        public Circle(int radius)
        {
            this.radius = radius;
        }
        /// <summary>
        /// get radius value
        /// </summary>
        /// <returns></returns>
        public int GetRadius()
        {
            return this.radius;
        }
        /// <summary>
        /// overwrites the old radius with the new one 
        /// </summary>
        /// <param name="radius"></param>
        public void SetRadius(int radius)
        {
            this.radius = radius;
        }
        /// <summary>
        /// get circumference of ther circle
        /// </summary>
        /// <returns></returns>
        public double GetCircumference()
        {
            return (double)this.radius * 2 * Math.PI;
        }
        /// <summary>
        /// get area of the circle
        /// </summary>
        /// <returns></returns>
        public double GetArea()
        {
            return (double)this.radius * (double)this.radius * Math.PI;
        }
    }
}
