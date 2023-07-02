namespace SquareCalc
{
    public abstract class Shape
    {
        /// <summary>
        /// Получение площади фигуры
        /// </summary>
        public double GetSquare => GetSquareCalc();

        /// <summary>
        /// Абстрактный метод вычисления площади фигуры
        /// </summary>
        /// <returns>площадь фигуры</returns>
        protected abstract double GetSquareCalc();
    }
}