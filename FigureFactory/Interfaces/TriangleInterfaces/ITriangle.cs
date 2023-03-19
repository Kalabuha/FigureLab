namespace FigureFactory.Interfaces.TriangleInterfaces
{
    public interface ITriangle : IFigure
    {
        #region Углы
        /// <summary>
        /// Возвращает значение угла A треугольника.
        /// </summary>
        public double AngleA { get; }

        /// <summary>
        /// Возвращает значение угла B треугольника.
        /// </summary>
        public double AngleB { get; }

        /// <summary>
        /// Возвращает значение угла C треугольника.
        /// </summary>
        public double AngleC { get; }
        #endregion

        #region Стороны
        /// <summary>
        /// Возвращает значение стороны AB треугольника.
        /// </summary>
        public double SideAB { get; }

        /// <summary>
        /// Возвращает значение стороны BC треугольника.
        /// </summary>
        public double SideBC { get; }

        /// <summary>
        /// Возвращает значение стороны AC треугольника.
        /// </summary>
        public double SideAC { get; }
        #endregion

        #region Особенности
        /// <summary>
        /// Возвращает true если треугольник прямоугольный. Иначе false.
        /// </summary>
        public bool IsRightTriangle { get; }

        /// <summary>
        /// Возвращает true если треугольник равнобедренный. Иначе false.
        /// </summary>
        public bool IsIsoscelesTriangle { get; }

        /// <summary>
        /// Возвращает true если треугольник равносторонний. Иначе false.
        /// </summary>
        public bool IsEquilateralTriangle { get; }
        #endregion
    }
}
