using FigureFactory.Base;
using FigureFactory.Interfaces.TriangleInterfaces;

namespace FigureFactory.Calculators
{
    public class TriangleCalculator : BaseCalculator, ITriangleCalculator
    {
        #region Вычисление площадей
        public double CalculateAreaAnAnglesAndSide(double angleA, double angleB, double angleC, double sideAB)
        {
            double radiansA = ConvertDegreesToRadians(angleA);
            double radiansB = ConvertDegreesToRadians(angleB);
            double radiansC = ConvertDegreesToRadians(angleC);

            return Math.Pow(sideAB, 2) * Math.Sin(radiansA) * Math.Sin(radiansB) / (2 * Math.Sin(radiansC));
        }

        public double CalculateAreaAnSidesAndAngle(double angleA, double sideAB, double sideAC)
        {
            double radians = ConvertDegreesToRadians(angleA);
            return sideAB * sideAC * Math.Sin(radians) / 2;
        }

        public double CalculateAreaAnSides(double sideAB, double sideAC, double sideBC)
        {
            double semiPerimeter = (sideAB + sideAC + sideBC) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - sideAB) * (semiPerimeter - sideAC) * (semiPerimeter - sideBC));
        }
        #endregion

        #region Вычисление углов
        public double CalculateAngleAnSumAngles(double angleA, double angleB)
        {
            return 180 - (angleA + angleB);
        }

        public double CalculateAngleAnAreaSideAndAngle(double angleA, double sideAB, double area)
        {
            double radians = ConvertDegreesToRadians(angleA);
            double x = Math.Pow(sideAB, 2) / (2 * area) - 1 / Math.Tan(radians);
            double radiansX = Math.PI / 2 - Math.Atan(x);
            return ConvertRadiansToDegrees(radiansX);
        }

        public double CalculateAngleAnTwoSidesAndArea(double sideAB, double sideAC, double area)
        {
            double x = 2 * area / (sideAB * sideAC);
            double radians = Math.Asin(x);
            return ConvertRadiansToDegrees(radians);
        }
        #endregion

        #region Вычисление сторон
        public double CalculateSideAnAngleAreaAndSide(double angleB, double sideAB, double area)
        {
            double radians = ConvertDegreesToRadians(angleB);
            return 2 * area / (sideAB * Math.Sin(radians));
        }
        #endregion
    }
}
