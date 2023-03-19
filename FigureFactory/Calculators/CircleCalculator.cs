using FigureFactory.Base;
using FigureFactory.Interfaces.CircleInterfaces;

namespace FigureFactory.Calculators
{
    public class CircleCalculator : BaseCalculator, ICircleCalculator
    {
        #region Вычисление площадей
        public double CalculateAreaAnRadius(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        #endregion

        #region Вычисление длины окружности
        public double CalculateCircumferenceAnRadius(double radius)
        {
            return 2 * Math.PI * radius;
        }
        #endregion
    }
}
