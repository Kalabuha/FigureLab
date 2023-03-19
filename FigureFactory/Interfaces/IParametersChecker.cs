namespace FigureFactory.Interfaces
{
    public interface IParametersChecker
    {
        public string? CheckParameterValues(params double[] parameters);

    }
}
