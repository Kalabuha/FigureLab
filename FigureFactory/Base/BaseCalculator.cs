using FigureFactory.Interfaces;

namespace FigureFactory.Base
{
    public class BaseCalculator : ICalculator
    {
        public double ConvertDegreesToRadians(double degrees)
        {
            return degrees * Math.PI / 180;
        }

        public double ConvertRadiansToDegrees(double radians)
        {
            return radians * 180 / Math.PI;
        }
    }
}
