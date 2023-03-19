namespace FigureFactory.Interfaces.CircleInterfaces
{
    public interface ICircle : IFigure
    {
        /// <summary>
        /// Возвращает значение радиуса окружности.
        /// </summary>
        public double Radius { get; }

        /// <summary>
        /// Возвращает значение диаметра окружности.
        /// </summary>
        public double Diameter { get; }
    }
}
