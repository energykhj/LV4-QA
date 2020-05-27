using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HKAssignment02.Tests
{
    [TestFixture]
    public class TriangleSolverTest
    {
        // Test for can not forming a triangle
        [Test]
        public void AnalyzeCanBeATriangle()
        {
            // Arrange
            int[] dimensions = { 10, 4, 4 };

            // Act
            string result = TriangleSolver.Analyze(dimensions);

            // Assert
            Assert.AreEqual("These numbers can not be triangle", result);
        }

        // Test for Scalene triangle with three different values
        [Test]
        public void AnalyzeForScalene()
        {
            // Arrange
            int[] dimensions = { 10, 11, 12 };

            // Act
            string result = TriangleSolver.Analyze(dimensions);

            // Assert
            Assert.AreEqual("It can be a Scalene triangle", result);
        }

        // Test for equilateral triangle with three same values
        [Test]
        public void AnalyzeForEquilateral()
        {
            // Arrange
            int[] dimensions = { 10, 10, 10 };

            // Act
            string result = TriangleSolver.Analyze(dimensions);

            // Assert
            Assert.AreEqual("It can be an Equilateral triangle", result);
        }

        // Test for isosceles triangle, ABB
        // A != B == C
        [Test]
        public void AnalyzeForIsoscelesABB()
        {
            // Arrange
            int[] dimensions = { 10, 20, 20 };

            // Act
            string result = TriangleSolver.Analyze(dimensions);

            // Assert
            Assert.AreEqual("It can be an Isosceles triangle", result);
        }

        // Test for isosceles triangle, ABA
        // A != B, B != C, A == C
        [Test]
        public void AnalyzeForIsoscelesABA()
        {
            // Arrange
            int[] dimensions = { 20, 10, 20 };

            // Act
            string result = TriangleSolver.Analyze(dimensions);

            // Assert
            Assert.AreEqual("It can be an Isosceles triangle", result);
        }

        // Test for isosceles triangle, AAB
        // A != B, B != C, A == C
        [Test]
        public void AnalyzeForIsoscelesAAB()
        {
            // Arrange
            int[] dimensions = { 20, 20, 10 };

            // Act
            string result = TriangleSolver.Analyze(dimensions);

            // Assert
            Assert.AreEqual("It can be an Isosceles triangle", result);
        }
    }
}
