using FigureFactory.Interfaces;

namespace FigureFactory.Base
{
    public abstract class BaseFigure : IFigure
    {
        public int FigureId { get; set; }
        public double Area { get; internal set; }
        public double Perimeter { get; internal set; }
    }
}
