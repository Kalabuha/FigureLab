namespace FigureFactory.Interfaces.TriangleInterfaces;

public interface ITriangleCreator
{
    /// <summary>
    /// Построить треугольник по двум углам и стороне между ними.
    /// Если не удаётся создать треугольник по какой-либо причине, выбрасывает исключение с сообщением.
    /// </summary>
    /// <param name="angleA">Угол A</param>
    /// <param name="angleB">Угол B</param>
    /// <param name="sideAB">Длина стороны между углами A и B</param>
    /// <returns></returns>
    public ITriangle CreateOnTwoAnglesAndSideBetween(double angleA, double angleB, double sideAB);

    /// <summary>
    /// Построить треугольник по двум сторонам и углу между ними.
    /// Если не удаётся создать треугольник по какой-либо причине, выбрасывает исключение с сообщением.
    /// </summary>
    /// <param name="angleA">Угол A</param>
    /// <param name="sideAB">Длина стороны между углами A и B</param>
    /// <param name="sideAC">Длина стороны между углами A и C</param>
    /// <returns></returns>
    public ITriangle CreateOnTwoSidesAndAngleBetween(double angleA, double sideAB, double sideAC);

    /// <summary>
    /// Построить треугольник по трём сторонам.
    /// Если не удаётся создать треугольник по какой-либо причине, выбрасывает исключение с сообщением.
    /// </summary>
    /// <param name="sideAB">Длина стороны между углами A и B</param>
    /// <param name="sideAC">Длина стороны между углами A и C</param>
    /// <param name="sideBC">Длина стороны между углами B и C</param>
    /// <returns></returns>
    public ITriangle CreateOnThreeSides(double sideAB, double sideAC, double sideBC);
}
