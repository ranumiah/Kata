using System;

namespace AreaCalculation
{
    internal class Circle : ICalculateShapeArea
    {
        private double _radius;

        public Circle(double radius)
        {
            this._radius = radius;
        }

        public double GetTotalArea()
        {
            return Math.Round(Math.PI * _radius * _radius, 2);
        }
    }
}