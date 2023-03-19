using FigureFactory.Base;
using FigureFactory.Interfaces.TriangleInterfaces;

namespace FigureFactory.Figures
{
    public class Triangle : BaseFigure, ITriangle
    {
        public double AngleA { get; private set; }
        public double AngleB { get; private set; }
        public double AngleC { get; private set; }

        public double SideAB { get; private set; }
        public double SideBC { get; private set; }
        public double SideAC { get; private set; }

        public bool IsRightTriangle { get => AngleA == 90 || AngleB == 90 || AngleC == 90; }
        public bool IsIsoscelesTriangle { get => SideAB == SideAC || SideAB == SideBC || SideAC == SideBC; }
        public bool IsEquilateralTriangle { get => SideAB == SideAC && SideAB == SideBC; }

        public Triangle(double angleA, double angleB, double angleC, double sideAB, double sideAC, double sideBC)
        {
            AngleA = angleA;
            AngleB = angleB;
            AngleC = angleC;

            SideAB = sideAB;
            SideAC = sideAC;
            SideBC = sideBC;

            Perimeter = sideAB + sideAC + sideBC;
        }
    }
}
