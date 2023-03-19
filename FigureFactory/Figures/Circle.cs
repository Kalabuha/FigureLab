using FigureFactory.Base;
using FigureFactory.Interfaces.CircleInterfaces;

namespace FigureFactory.Figures
{
    public class Circle : BaseFigure, ICircle
    {
        public double Radius { get; private set; }
        public double Diameter{ get => 2 * Radius; }

        public Circle(double radius)
        {
            Radius = radius;
        }
    }
}
