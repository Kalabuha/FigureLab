using FigureModels.Base;

namespace FigureModels
{
    public class CircleModel : BaseFigureModel
    {
        public CircleModel(double radius)
        {
            Radius = radius;
        }

        public double Radius { get; private set; }

        public override double? GetFigureArea()
        {
            if (VerifyLessOrEqualZeroOrNullValues(Radius))
            {
                return null;
            }

            var area = Math.PI * Math.Pow(Radius, 2);
            return area;
        }

        public override double? GetPerimeter()
        {
            if (VerifyLessOrEqualZeroOrNullValues(Radius))
            {
                return null;
            }

            var circumference = 2 * Math.PI * Radius;
            return circumference;
        }
    }
}
