using FigureFactory.Interfaces.TriangleInterfaces;
using Microsoft.Extensions.DependencyInjection;

namespace FigureTestProject
{
    public class TriangleTests
    {
        private IServiceProvider factoryServiceProvider;

        public TriangleTests()
        {
            factoryServiceProvider = ServiceProviderBuilder.Build();
        }

        [Theory]
        //нормальный треугольник
        [InlineData(20d, 21d, 23d, 64d)]

        //кривые треугольники
        [InlineData(20d, 0, 23d, null)]
        [InlineData(20d, -21d, 23d, null)]
        public void PerimeterComputationTest(double sideAB, double sideAC, double sideBC, double? expectedPerimeter)
        {
            var triangleCreator = factoryServiceProvider.GetRequiredService<ITriangleCreator>();

            ITriangle? triangle;
            try
            {
                triangle = triangleCreator.CreateOnThreeSides(sideAB, sideAC, sideBC);
            }
            catch (Exception)
            {
                triangle = null;
            }

            double? actualPerimeter = triangle?.Perimeter;
            Assert.Equal(expectedPerimeter, actualPerimeter);
        }

        [Theory]
        //нормальный треугольник
        [InlineData(10d, 12d, 10d, 48d)]

        //кривые треугольники
        [InlineData(10d, 120d, 10d, null)]
        [InlineData(10d, -12d, 10d, null)]
        [InlineData(10d, 0d, 10d, null)]
        public void AreaComputationTest(double sideAB, double sideAC, double sideBC, double? expectedArea)
        {
            var triangleCreator = factoryServiceProvider.GetRequiredService<ITriangleCreator>();

            ITriangle? triangle;
            try
            {
                triangle = triangleCreator.CreateOnThreeSides(sideAB, sideAC, sideBC);
            }
            catch (Exception)
            {
                triangle = null;
            }

            double? actualArea = triangle?.Area;
            Assert.Equal(expectedArea, actualArea);
        }

        [Theory]
        //прямоугольный треугольник
        [InlineData(10d, 24d, 26d, true)]

        //не прямоугольный треугольник
        [InlineData(11d, 15d, 17d, false)]

        //кривые треугольники
        [InlineData(14d, 0, 16d, null)]
        [InlineData(16d, -12d, 16d, null)]
        public void IsRightTriangleDetermineTest(double sideAB, double sideAC, double sideBC, bool? expectedIsRightTriangle)
        {
            var triangleCreator = factoryServiceProvider.GetRequiredService<ITriangleCreator>();

            ITriangle? triangle;
            try
            {
                triangle = triangleCreator.CreateOnThreeSides(sideAB, sideAC, sideBC);
            }
            catch (Exception)
            {
                triangle = null;
            }

            bool? actualIsRightTriangle = triangle?.IsRightTriangle;
            Assert.Equal(expectedIsRightTriangle, actualIsRightTriangle);
        }
    }
}
