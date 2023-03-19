using FigureFactory.Interfaces.CircleInterfaces;
using Microsoft.Extensions.DependencyInjection;

namespace FigureTestProject
{
    public class CircleTests
    {
        private readonly IServiceProvider factoryServiceProvider;

        public CircleTests()
        {
            factoryServiceProvider = ServiceProviderBuilder.Build();
        }

        [Theory]
        //нормальный круг
        [InlineData(17d, 106.81d)]

        //кривые круги
        [InlineData(0d, null)]
        [InlineData(-16d, null)]
        public void PerimeterComputationTest(double radius, double? expectedPerimeter)
        {
            var circleCreator = factoryServiceProvider.GetRequiredService<ICircleCreator>();

            ICircle? circle;
            try
            {
                circle = circleCreator.CreateAnRadius(radius);
            }
            catch (Exception)
            {
                circle = null;
            }


            double? actualPerimeterRound = circle?.Perimeter;
            if (actualPerimeterRound.HasValue)
            {
                actualPerimeterRound = Math.Round(actualPerimeterRound.Value, 2);
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
            var circleCreator = factoryServiceProvider.GetRequiredService<ICircleCreator>();

            ICircle? circle;
            try
            {
                circle = circleCreator.CreateAnRadius(radius);
            }
            catch (Exception)
            {
                circle = null;
            }

            double? actualAreaRound = circle?.Area;
            if (actualAreaRound.HasValue)
            {
                actualAreaRound = Math.Round(actualAreaRound.Value, 2);
            }

            Assert.Equal(expectedArea, actualAreaRound);
        }
    }
}