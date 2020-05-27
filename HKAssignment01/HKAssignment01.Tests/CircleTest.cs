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

using NUnit.Framework;

namespace HKAssignment01.Tests
{
    /// <summary>
    /// Test Circle
    /// </summary>
    [TestFixture]
    public class CircleTest
    {
        Circle c;
        int radius;

        /// <summary>
        /// Setup for the test
        /// </summary>
        [SetUp]
        public void InitRadius()
        {
            c = new Circle(6);
            radius = 0;
        }
        /// <summary>
        /// test GetRadiuse()
        /// </summary>
        [Test]
        public void GetRadiusValueisIntiger()
        {
            //Act
            radius = c.GetRadius();

            //Asser
            Assert.AreEqual(radius, 6);
        }
        /// <summary>
        /// test greater than zero value
        /// </summary>
        [Test]
        public void GetRadiusValueisGreaterThanZero()
        {
            Assert.Greater(c.GetRadius(), 0);
        }

        /// <summary>
        /// test SetRadius()
        /// </summary>
        [Test]
        public void SetRadiusValue()
        {
            radius = c.GetRadius();
            Assert.AreEqual(radius, 6);

            c.SetRadius(3);

            radius = c.GetRadius();
            Assert.AreEqual(radius, 3);
        }

        /// <summary>
        /// test GetCircumference()
        /// </summary>
        [Test]
        public void GetCircumferenceValue()
        {
            double Circumference = c.GetCircumference();
            Assert.AreEqual(Math.Round(Circumference, 2), 37.70);
        }

        /// <summary>
        /// test GetAreaValue()
        /// </summary>
        [Test]
        public void GetAreaValue()
        {
            double area = c.GetArea();
            Assert.AreEqual(Math.Round(area, 2), 113.10);
        }
    }
}
