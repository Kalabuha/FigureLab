namespace FigureModels.Base
{
    public abstract class BaseFigureModel
    {
        public abstract double? GetFigureArea();
        public abstract double? GetPerimeter();

        protected virtual bool VerifyLessOrEqualZeroOrNullValues(params double?[] values)
        {
            return values.Any(v => v <= 0 || v == null);
        }
    }
}
