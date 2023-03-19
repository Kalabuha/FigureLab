using FigureFactory.Calculators;
using FigureFactory.Checkers;
using FigureFactory.Creators;
using FigureFactory.Interfaces.CircleInterfaces;
using FigureFactory.Interfaces.TriangleInterfaces;
using Microsoft.Extensions.DependencyInjection;

namespace FigureFactory
{
    public static class ServiceProviderBuilder
    {
        public static IServiceProvider Build()
        {
            var services = new ServiceCollection();

            services.AddSingleton<ICircleParametersChecker, CircleParametersChecker>();
            services.AddSingleton<ICircleCalculator, CircleCalculator>();
            services.AddSingleton<ICircleCreator, CircleCreator>();

            services.AddSingleton<ITriangleParametersChecker, TriangleParameterChecker>();
            services.AddSingleton<ITriangleCalculator, TriangleCalculator>();
            services.AddSingleton<ITriangleCreator, TriangleCreator>();

            return services.BuildServiceProvider();
        }
    }
}
