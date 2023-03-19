namespace FigureFactory.Interfaces.TriangleInterfaces
{
    public interface ITriangleCalculator : ICalculator
    {
        /// <summary>
        /// Вычисляет площадь треугольника по углам и стороне.
        /// </summary>
        /// <param name="angleA">Угол A, прилежащий к стороне AB.</param>
        /// <param name="angleB">Угол B, прилежащий к стороне AB.</param>
        /// <param name="angleC">Угол C, противолежащий стороне AB.</param>
        /// <param name="sideAB">Сторона треугольника мужду углами A и B.</param>
        /// <returns></returns>
        public double CalculateAreaAnAnglesAndSide(double angleA, double angleB, double angleC, double sideAB);

        /// <summary>
        /// Вычисляет площадь треугольника по двум сторонам и углу между ними.
        /// </summary>
        /// <param name="angleA">Угол A.</param>
        /// <param name="sideAB">Сторона треугольника мужду углами A и B.</param>
        /// <param name="sideAC">Сторона треугольника мужду углами A и C.</param>
        /// <returns></returns>
        public double CalculateAreaAnSidesAndAngle(double angleA, double sideAB, double sideAC);

        /// <summary>
        /// Вычисляет площадь треугольника по трём сторонам, используя формулу Герона.
        /// </summary>
        /// <param name="sideAB">Сторона треугольника мужду углами A и B.</param>
        /// <param name="sideAC">Сторона треугольника мужду углами A и C.</param>
        /// <param name="sideBC">Сторона треугольника мужду углами B и C.</param>
        /// <returns></returns>
        public double CalculateAreaAnSides(double sideAB, double sideAC, double sideBC);

        /// <summary>
        /// Вычисляет угол по двум другим углам из суммы всех углов.
        /// </summary>
        /// <param name="angleA">Угол A.</param>
        /// <param name="angleB">Угол B.</param>
        /// <returns></returns>
        public double CalculateAngleAnSumAngles(double angleA, double angleB);

        /// <summary>
        /// Вычисляет угол B по стороне между углами AB, площади, и углу A.
        /// </summary>
        /// <param name="angleA">Угол A</param>
        /// <param name="sideAB">Сторона треугольника мужду углами A и B.</param>
        /// <param name="area">Площадь треугольника</param>
        /// <returns></returns>
        public double CalculateAngleAnAreaSideAndAngle(double angleA, double sideAB, double area);

        /// <summary>
        /// Вычисляет сторону по углу, к которому прилегает вычисляемая сторона, по площади и стороне, прилежащей к используемому углу.
        /// </summary>
        /// <param name="angleB">Угол B</param>
        /// <param name="sideAB">Сторона треугольника мужду углами A и B.</param>
        /// <param name="area">Площадь треугольника</param>
        /// <returns></returns>
        public double CalculateSideAnAngleAreaAndSide(double angleB, double sideAB, double area);

        /// <summary>
        /// Вычисляет угол по двум прилежащим к этому углу сторонам и площади.
        /// </summary>
        /// <param name="sideAB">Сторона треугольника мужду углами A и B.</param>
        /// <param name="sideAC">Сторона треугольника мужду углами A и C.</param>
        /// <param name="area">Площадь треугольника</param>
        /// <returns></returns>
        public double CalculateAngleAnTwoSidesAndArea(double sideAB, double sideAC, double area);

    }
}
