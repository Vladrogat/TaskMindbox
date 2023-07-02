using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareCalc.Tests
{
    [TestFixture]
    public class TriangleTests
    {
        /// <summary>
        /// Тест первая сторона меньше нуля 
        /// </summary>
        [Test]
        public void TriangleNegativeFirstSideTest()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(10, 2, -4));
            
        }
        /// <summary>
        /// Тест вторая сторона меньше нуля
        /// </summary>
        [Test]
        public void TriangleNegativeSecondSideTest()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(0, 2, 4));

        }
        /// <summary>
        /// Тесттретья сторона меньше нуля
        /// </summary>
        [Test]
        public void TriangleNegativeTrirdSideTest()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-9, 2, 6));

        }

        /// <summary>
        /// Тест вычисление площади треугольника со сторонами 10 4 8
        /// </summary>
        [Test]
        public void RightTriangleCalcSquareTest()
        {
            Triangle triangle = new Triangle(10, 4, 8);

            double triangleSquare = triangle.GetSquare;

            Assert.That(triangleSquare, Is.EqualTo(15.20));
        }

        /// <summary>
        /// Тест вычисление площади прямоугольного треугольника со сторонами 5 4 3
        /// </summary>
        [Test]
        public void TriangleCalcSquareTest()
        {
            Triangle triangle = new Triangle(5, 4, 3);

            double triangleSquare = triangle.GetSquare;

            Assert.That(triangleSquare, Is.EqualTo(6.00));
        }
    }
}
