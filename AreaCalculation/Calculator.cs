using System;

namespace AreaCalculation
{
    internal class Calculator
    {
        public double GetTotalArea(Triangle triangle)
        {
           return triangle.GetTotalArea();
        }

        internal double GetTotalArea(Rectangle rectangle1, Rectangle rectangle2, Circle circle, Square square, Triangle triangle)
        {
            return rectangle1.GetTotalArea() + rectangle2.GetTotalArea() + circle.GetTotalArea() + square.GetTotalArea() +
                   triangle.GetTotalArea();
        }

        internal double GetTotalArea(Rectangle rectangle1, Rectangle rectangle2)
        {
            return Math.Round(rectangle1.GetTotalArea() + rectangle2.GetTotalArea(), 2);
        }

        internal double GetTotalArea()
        {
            return 0;
        }

        internal double GetTotalArea(Circle circle)
        {
            return circle.GetTotalArea();
        }

        internal double GetTotalArea(Square square)
        {
            return square.GetTotalArea();
        }

        internal double GetTotalArea(Rectangle rectangle)
        {
            return rectangle.GetTotalArea();
        }
    }
}