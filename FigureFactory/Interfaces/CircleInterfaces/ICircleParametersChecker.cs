﻿namespace FigureFactory.Interfaces.CircleInterfaces
{
    public interface ICircleParametersChecker : IParametersChecker
    {
        /// У кругов вроде нет ограничений по радиусу, проверять особо нечего, но можно здесь добавить различные проверки,
        /// если возникнет необходимость. Например добавить проверку координат, по которым тоже можно строить окружность.
        /// Или проверку вписанного квадрата, по которому тоже можно строить окружность и т.д.
    }
}
