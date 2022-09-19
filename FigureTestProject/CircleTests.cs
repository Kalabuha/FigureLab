namespace FigureTestProject
{
    public class CircleTests
    {
        [Theory]
        //нормальный круг
        [InlineData(17d, 106.81d)]

        //кривые круги
        [InlineData(0d, null)]
        [InlineData(-16d, null)]
        public void PerimeterComputationTest(double radius, double? expectedPerimeter)
        {
            var circle = new CircleModel(radius);
            var actualPerimeter = circle.GetPerimeter();

            double? actualPerimeterRound = null;
            if (actualPerimeter.HasValue)
            {
                actualPerimeterRound = Math.Round(actualPerimeter.Value, 2);
            }

            Assert.Equal(expectedPerimeter, actualPerimeterRound);
        }

        [Theory]
        //нормальный круг
        [InlineData(16d, 804.25d)]

        //кривые круги
        [InlineData(0d, null)]
        [InlineData(-12d, null)]
        public void AreaComputationTest(double radius, double? expectedArea)
        {
            var circle = new CircleModel(radius);
            var actualArea = circle.GetFigureArea();

            double? actualAreaRound = null;
            if (actualArea.HasValue)
            {
                actualAreaRound = Math.Round(actualArea.Value, 2);
            }

            Assert.Equal(expectedArea, actualAreaRound);
        }
    }
}