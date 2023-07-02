using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareCalc.Shapes
{
    public class Triangle : Shape
    {
        private double FirstSide;

        private double SecondSide;
        
        private double TrirdSide;

        /// <summary>
        /// Конструктор  треугольника
        /// </summary>
        /// <param name="firstSide">первая сторона</param>
        /// <param name="secondSide">вторая торона</param>
        /// <param name="trirdSide">третья сторона</param>
        /// <exception cref="ArgumentOutOfRangeException">стороны меньше нуля</exception>
        public Triangle(double firstSide, double secondSide, double trirdSide)
        {
            if (firstSide <= 0 || secondSide <= 0 || trirdSide <= 0)
            {
                throw new ArgumentOutOfRangeException("Стороны должны быть больше нуля");
            }
            this.FirstSide = firstSide;
            this.SecondSide = secondSide;
            this.TrirdSide = trirdSide;
        }

        /// <summary>
        /// вычисление площади треугольника
        /// </summary>
        /// <returns>площадь треугольника</returns>
        protected override double GetSquareCalc()
        {
            if (this.CheckRightTriangle())
            {
                List<double> sides = new[] { FirstSide, SecondSide, TrirdSide }.OrderBy(side => side).ToList();
                return (sides[0] * sides[1]) / 2;
            }

            double halfPerimetr = (FirstSide + SecondSide + TrirdSide) / 2;

            return Math.Round( Math.Sqrt(
                    halfPerimetr * (halfPerimetr - FirstSide) 
                    * (halfPerimetr - SecondSide) 
                    * (halfPerimetr - TrirdSide)
                ), 2);

        }

        /// <summary>
        /// Проверка, является ли треугольник прямоугольным
        /// </summary>
        /// <returns>Является ли тругольник прямоугольным</returns>
        protected bool CheckRightTriangle()
        {
            List<double> sides = new[] { FirstSide, SecondSide, TrirdSide }.OrderBy(side => side).ToList();

            return sides.First() * sides.First() + sides[1] * sides[1] == sides.Last() * sides.Last();

        }
    }
}
