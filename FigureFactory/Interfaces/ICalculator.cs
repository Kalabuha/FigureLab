using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureFactory.Interfaces
{
    public interface ICalculator
    {
        /// <summary>
        /// Преобразует градусы в радианы.
        /// </summary>
        /// <param name="degrees">Угол в градусах.</param>
        /// <returns>Угол в радианах.</returns>
        public double ConvertDegreesToRadians(double degrees);

        /// <summary>
        /// Преобразует радианы в градусы.
        /// </summary>
        /// <param name="radians">Угол в радианах.</param>
        /// <returns>Угол в градусах.</returns>
        public double ConvertRadiansToDegrees(double radians);
    }
}
