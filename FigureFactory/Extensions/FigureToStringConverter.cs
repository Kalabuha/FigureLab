using FigureFactory.Interfaces;
using FigureFactory.Interfaces.TriangleInterfaces;
using FigureFactory.Interfaces.CircleInterfaces;

namespace FigureFactory.Extensions
{
    public static class FigureToStringConverter
    {
        public static string ConvertFigureToStringName(this IFigure figure)
        {
            if (figure is ITriangle)
            {
                return "Треугольник";
            }
            else if (figure is ICircle)
            {
                return "Михаил Круг";
            }

            return "unknown";
        }
    }
}
