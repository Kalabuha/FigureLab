namespace FigureFactory.Interfaces.CircleInterfaces
{
    public interface ICircleCreator
    {
        /// <summary>
        /// Построить окружность по радиусу.
        /// </summary>
        /// <param name="radius">Радиус окружности.</param>
        /// <returns>Экземпляр окружности.</returns>
        public ICircle CreateAnRadius(double radius);

        /// <summary>
        /// Построить окружность по диаметру.
        /// </summary>
        /// <param name="diameter">Диаметр окружности.</param>
        /// <returns>Экземпляр окружности.</returns>
        public ICircle CreateAnDiameter(double diameter);

    }
}
