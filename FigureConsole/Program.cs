using FigureFactory;
using FigureFactory.Interfaces.TriangleInterfaces;
using Microsoft.Extensions.DependencyInjection;

// Тесты в другом проекте, здесь сравнение по способу создания треугольников.

var factoryServiceProvider = ServiceProviderBuilder.Build();
var triangleCreator = factoryServiceProvider.GetRequiredService<ITriangleCreator>();

Console.WriteLine("Все треугольники с одинаковыми параметрами, но построены по разными входными данными.\n");

Console.WriteLine("Треугольник построеный по трём сторонам");
var triangleOne = triangleCreator.CreateOnThreeSides(10d, 24d, 26d);
Console.WriteLine($"Стороны: {Math.Round(triangleOne.SideAB)}, {Math.Round(triangleOne.SideAC)}, {Math.Round(triangleOne.SideBC)}");
Console.WriteLine($"Углы: {triangleOne.AngleA}, {triangleOne.AngleB}, {triangleOne.AngleC}");
Console.WriteLine($"Площадь: {Math.Round(triangleOne.Area)}");
Console.WriteLine($"Периметр: {Math.Round(triangleOne.Perimeter)}\n");

Console.WriteLine("Треугольник построеный по одному углу и двум сторонам");
var triangleTwo = triangleCreator.CreateOnTwoSidesAndAngleBetween(90d, 10d, 24d);
Console.WriteLine($"Стороны: {Math.Round(triangleTwo.SideAB)}, {Math.Round(triangleTwo.SideAC)}, {Math.Round(triangleTwo.SideBC)}");
Console.WriteLine($"Углы: {triangleTwo.AngleA}, {triangleTwo.AngleB}, {triangleTwo.AngleC}");
Console.WriteLine($"Площадь: {Math.Round(triangleTwo.Area)}");
Console.WriteLine($"Периметр: {Math.Round(triangleTwo.Perimeter)}\n");

Console.WriteLine("Треугольник построеный по двум углам и одной стороне");
var triangleThree = triangleCreator.CreateOnTwoAnglesAndSideBetween(90d, 67.380135d, 10);
Console.WriteLine($"Стороны: {Math.Round(triangleThree.SideAB)}, {Math.Round(triangleThree.SideAC)}, {Math.Round(triangleThree.SideBC)}");
Console.WriteLine($"Углы: {triangleThree.AngleA}, {triangleThree.AngleB}, {triangleThree.AngleC}");
Console.WriteLine($"Площадь: {Math.Round(triangleThree.Area)}");
Console.WriteLine($"Периметр: {Math.Round(triangleThree.Perimeter)}\n");
