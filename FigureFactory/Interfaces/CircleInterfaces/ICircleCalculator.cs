namespace FigureFactory.Interfaces.CircleInterfaces
{
    public interface ICircleCalculator : ICalculator
    {
        /// <summary>
        /// Вычислить площадь окружности по её радиусу.
        /// </summary>
        /// <param name="radius">Радиус окружности.</param>
        /// <returns>Площадь окружности.</returns>
        public double CalculateAreaAnRadius(double radius);

        /// <summary>
        /// Вычислить длину оружности по его радиусу.
        /// </summary>
        /// <param name="radius">Радиус окружности.</param>
        /// <returns>Площадь окружности.</returns>
        public double CalculateCircumferenceAnRadius(double radius);
    }
}
