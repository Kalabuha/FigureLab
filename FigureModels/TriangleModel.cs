using FigureModels.Base;

namespace FigureModels
{
    public class TriangleModel : BaseFigureModel
    {
        public TriangleModel(double sideAB, double sideAC, double sideBC)
        {
            SideAB = sideAB;
            SideAC = sideAC;
            SideBC = sideBC;
        }

        public double SideAB { get; private set; }
        public double SideBC { get; private set; }
        public double SideAC { get; private set; }
        public bool? IsRightTriangle
        {
            get
            {
                if (base.VerifyLessOrEqualZeroOrNullValues(SideAB, SideAC, SideBC))
                {
                    return null;
                }

                var sides = new double[] { SideAB, SideBC, SideAC };
                var orderedSides = sides.OrderBy(s => s).ToArray();
                return Math.Pow(orderedSides[2], 2) == Math.Pow(orderedSides[1], 2) + Math.Pow(orderedSides[0], 2);
            }
        }

        public override double? GetFigureArea()
        {
            var perimeter = GetPerimeter();
            if (!perimeter.HasValue)
            {
                return null;
            }

            var semiPerimeter = perimeter.Value / 2;
            var underSqrtExpression = semiPerimeter * (semiPerimeter - SideAB) * (semiPerimeter - SideAC) * (semiPerimeter - SideBC);
            if (underSqrtExpression <= 0)
            {
                return null;
            }

            var area = Math.Sqrt(underSqrtExpression);
            return area;
        }

        public override double? GetPerimeter()
        {
            if (base.VerifyLessOrEqualZeroOrNullValues(SideAB, SideAC, SideBC))
            {
                return null;
            }

            return SideAB + SideAC + SideBC;
        }
    }
}
