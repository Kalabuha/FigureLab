using FigureFactory.Interfaces.TriangleInterfaces;
using FigureFactory.Figures;

namespace FigureFactory.Creators
{
    public class TriangleCreator : ITriangleCreator
    {
        private readonly ITriangleCalculator triangleCalculator;
        private readonly ITriangleParametersChecker triangleParametersChecker;

        public TriangleCreator(ITriangleCalculator triangleCalculator, ITriangleParametersChecker triangleParametersChecker)
        {
            this.triangleCalculator = triangleCalculator;
            this.triangleParametersChecker = triangleParametersChecker;
        }

        public ITriangle CreateOnTwoAnglesAndSideBetween(double angleA, double angleB, double sideAB)
        {
            var message = triangleParametersChecker.CheckParameterValues(angleA, angleB, sideAB);
            if (!string.IsNullOrEmpty(message))
            {
                throw new ArgumentException(message);
            }

            double angleC = triangleCalculator.CalculateAngleAnSumAngles(angleA, angleB);

            message = triangleParametersChecker.CheckAngleValues(angleC);
            if (!string.IsNullOrEmpty(message))
            {
                throw new ArgumentException(message);
            }

            double area = triangleCalculator.CalculateAreaAnAnglesAndSide(angleA, angleB, angleC, sideAB);
            double sideAC = triangleCalculator.CalculateSideAnAngleAreaAndSide(angleA, sideAB, area);
            double sideBC = triangleCalculator.CalculateSideAnAngleAreaAndSide(angleB, sideAB, area);

            Triangle triangle = new (angleA, angleB, angleC, sideAB, sideAC, sideBC);
            triangle.Area = area;
            return triangle;
        }

        public ITriangle CreateOnTwoSidesAndAngleBetween(double angleA, double sideAB, double sideAC)
        {
            var message = triangleParametersChecker.CheckParameterValues(angleA, sideAB, sideAC);
            if (!string.IsNullOrEmpty(message))
            {
                throw new ArgumentException(message);
            }

            message = triangleParametersChecker.CheckAngleValues(angleA);
            if (!string.IsNullOrEmpty(message))
            {
                throw new ArgumentException(message);
            }

            double area = triangleCalculator.CalculateAreaAnSidesAndAngle(angleA, sideAB, sideAC);
            double angleB = triangleCalculator.CalculateAngleAnAreaSideAndAngle(angleA, sideAB, area);
            double angleC = triangleCalculator.CalculateAngleAnSumAngles(angleA, angleB);
            double sideBC = triangleCalculator.CalculateSideAnAngleAreaAndSide(angleB, sideAB, area);

            Triangle triangle = new (angleA, angleB, angleC, sideAB, sideAC, sideBC);
            triangle.Area = area;
            return triangle;
        }

        public ITriangle CreateOnThreeSides(double sideAB, double sideAC, double sideBC)
        {
            var message = triangleParametersChecker.CheckParameterValues(sideAB, sideAC, sideBC);
            if (!string.IsNullOrEmpty(message))
            {
                throw new ArgumentException(message);
            }

            message = triangleParametersChecker.CheckSidesRatio(sideAB, sideAC, sideBC);
            if (!string.IsNullOrEmpty(message))
            {
                throw new ArgumentException(message);
            }

            double area = triangleCalculator.CalculateAreaAnSides(sideAB, sideAC, sideBC);
            double angleA = triangleCalculator.CalculateAngleAnTwoSidesAndArea(sideAB, sideAC, area);
            double angleB = triangleCalculator.CalculateAngleAnTwoSidesAndArea(sideAB, sideBC, area);
            double angleC = triangleCalculator.CalculateAngleAnTwoSidesAndArea(sideAC, sideBC, area);

            Triangle triangle = new(angleA, angleB, angleC, sideAB, sideAC, sideBC);
            triangle.Area = area;
            return triangle;
        }
    }
}
