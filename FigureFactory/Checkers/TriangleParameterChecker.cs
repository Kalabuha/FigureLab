using FigureFactory.Base;
using FigureFactory.Interfaces.TriangleInterfaces;

namespace FigureFactory.Checkers
{
    public class TriangleParameterChecker : BaseParametersChecker, ITriangleParametersChecker
    {
        private const double LimitSumAnglesOfTriangle = 180;

        private const string AngleExceptionMessage = "Недопустимое значение угла, он не может ровняться или превышать 180 градусов.";
        private const string AnglesExceptionMessage = "Недопустимое значение углов, их сумма не может ровняться или превышать 180 градусов.";
        private const string SidesExceptionMessage = "С указанными величинами сторон невозможно построить треугольник." +
            " Сумма двух наименьших сторон не может быть меньше или равняться третей стороне треугольника";

        public string? CheckAngleValues(params double[] angles)
        {
            switch (angles.Length)
            {
                case 1:
                    if (angles[0] >= LimitSumAnglesOfTriangle)
                    {
                        return AngleExceptionMessage;
                    }
                    break;

                case 2:
                    if (angles[0] + angles[1] >= LimitSumAnglesOfTriangle)
                    {
                        return AnglesExceptionMessage;
                    }
                    break;

                case 3:
                    if (angles[0] + angles[1] + angles[2] != LimitSumAnglesOfTriangle)
                    {
                        return AnglesExceptionMessage;
                    }
                    break;

                default: return NoParametersExceptionMessage;
            }

            return null;
        }

        public string? CheckSidesRatio(double firstSide, double sacondSide, double thirdSide)
        {
            double[] sides = new double[] { firstSide, sacondSide, thirdSide };
            var sortedSides = sides.OrderBy(s => s).ToArray();

            if (sortedSides[0] + sortedSides[1] <= sortedSides[2])
            {
                return SidesExceptionMessage;
            }

            return null;
        }
    }
}
