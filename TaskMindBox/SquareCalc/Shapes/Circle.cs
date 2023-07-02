using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareCalc.Shapes
{
    public class Circle: Shape
    {
        /// <summary>
        /// Радиус круга
        /// </summary>
        private double Radius;

        /// <summary>
        /// Константа Пи
        /// </summary>
        private double Pi => Math.PI;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="radius">радиус круга</param>
        /// <exception cref="ArgumentOutOfRangeException">радиус меньше нуля</exception>
        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw  new ArgumentOutOfRangeException("Радиус должен быть не отрицательным");
            }

            Radius = radius;
        }

        /// <summary>
        /// Вычисление площади круга
        /// </summary>
        /// <returns></returns>
        protected override double GetSquareCalc() => Math.Round(Pi * Radius * Radius, 2);
    }
}
