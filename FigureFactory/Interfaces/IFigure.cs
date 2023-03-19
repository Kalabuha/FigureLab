namespace FigureFactory.Interfaces
{
    public interface IFigure
    {
        /// <summary>
        /// Возвращает значение уникального ID для данной фигуры.
        /// </summary>
        public int FigureId { get; set; }

        /// <summary>
        /// Возвращает значение площади фигуры.
        /// </summary>
        public double Area { get; }

        /// <summary>
        /// Возвращает значение периметра фигуры.
        /// </summary>
        public double Perimeter { get; }
    }
}
