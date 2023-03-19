namespace FigureFactory.Interfaces.TriangleInterfaces;

public interface ITriangleParametersChecker : IParametersChecker
{
    /// <summary>
    /// Выполняет проверку углов, известно что сумма всех углов в треугольнике не может равняться или превышать значение 180 градусов.
    /// </summary>
    /// <param name="angles">Значения углов, в количестве от 1 до 3 включительно.</param>
    /// <returns>Сообщение в случае если проверка не пройдена успешно. Если она пройдена успешно возвращается null.</returns>
    public string? CheckAngleValues(params double[] angles);

    /// <summary>
    /// Выполняет проверку проверку сторон треуголника,
    /// известно что сумма наименьших двух сторон треугольника не может быть меньше или равняться третей стороне.
    /// </summary>
    /// <param name="firstSide">Первая сторона треугольника.</param>
    /// <param name="sacondSide">Вторая сторона треугольника.</param>
    /// <param name="thirdSide">Третья сторона треугольника.</param>
    /// <returns>Сообщение в случае если проверка не пройдена успешно. Если она пройдена успешно возвращается null.</returns>
    public string? CheckSidesRatio(double firstSide, double sacondSide, double thirdSide);
}
