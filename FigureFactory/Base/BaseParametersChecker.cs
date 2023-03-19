using FigureFactory.Interfaces;

namespace FigureFactory.Base
{
    public class BaseParametersChecker : IParametersChecker
    {
        protected const string NoParametersExceptionMessage = "Параметры для проверки не переданы.";
        protected const string SubZeroParametersExceptionMessage = "Недопустимо использование параметров равных или меньше 0.";

        public string? CheckParameterValues(params double[] parameters)
        {
            if (parameters.Length == 0)
            {
                return NoParametersExceptionMessage;
            }
            else if (parameters.Any(p => p <= 0))
            {
                return SubZeroParametersExceptionMessage;
            }

            return null;
        }
    }
}
