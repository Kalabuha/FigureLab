using FigureFactory.Figures;
using FigureFactory.Interfaces.CircleInterfaces;

namespace FigureFactory.Creators
{
    internal class CircleCreator : ICircleCreator
    {
        private ICircleParametersChecker circleParametersChecker;
        private ICircleCalculator circleCalculator;

        public CircleCreator(ICircleCalculator circleCalculator, ICircleParametersChecker circleParametersChecker)
        {
            this.circleCalculator = circleCalculator;
            this.circleParametersChecker = circleParametersChecker;
        }

        public ICircle CreateAnRadius(double radius)
        {
            var message = circleParametersChecker.CheckParameterValues(radius);
            if (!string.IsNullOrEmpty(message))
            {
                throw new ArgumentException(message);
            }

            double area = circleCalculator.CalculateAreaAnRadius(radius);
            double circumference = circleCalculator.CalculateCircumferenceAnRadius(radius);

            Circle circle = new(radius);
            circle.Area = area;
            circle.Perimeter = circumference;
            return circle;
        }

        public ICircle CreateAnDiameter(double diameter)
        {
            double radius = diameter / 2;
            return CreateAnRadius(radius);
        }
    }
}
