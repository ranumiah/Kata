namespace Kata
{
    using System;
    using System.Linq;

    public abstract class CalculateShapeArea
    {
        public abstract double GetTotalArea();
    }

    public class Triangle : CalculateShapeArea
    {
        private readonly double _triangleBase;
        private readonly double _triangleHeight;

        public Triangle(double triangleBase, double triangleHeight)
        {
            _triangleBase = triangleBase;
            _triangleHeight = triangleHeight;
        }

        public override double GetTotalArea()
        {
            return _triangleBase * _triangleHeight / 2;
        }
    }

    public class Square : CalculateShapeArea
    {
        private readonly double _side;

        public Square(double side)
        {
            _side = side;
        }

        public override double GetTotalArea()
        {
            return _side * _side;
        }
    }

    public class Rectangle : CalculateShapeArea
    {
        private readonly double _height;
        private readonly double _width;

        public Rectangle(double height, double width)
        {
            _height = height;
            _width = width;
        }

        public override double GetTotalArea()
        {
            return _height * _width;
        }
    }

    public class Circle : CalculateShapeArea
    {
        private readonly double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public override double GetTotalArea()
        {
            return Math.Round(Math.PI * _radius * _radius, 2);
        }
    }

    public class Calculator
    {
        public double GetTotalArea(Triangle triangle)
        {
            return triangle.GetTotalArea();
        }

        public double GetTotalArea(Rectangle rectangle1, Rectangle rectangle2, Circle circle, Square square, Triangle triangle)
        {
            return rectangle1.GetTotalArea() + rectangle2.GetTotalArea() + circle.GetTotalArea() + square.GetTotalArea() +
                   triangle.GetTotalArea();
        }
        public double GetTotalArea(params CalculateShapeArea[] shapesAreas)
        {
            return Math.Round(shapesAreas.ToList().Sum(x => x.GetTotalArea()), 2);
        }

        public double GetTotalArea(Rectangle rectangle1, Rectangle rectangle2)
        {
            return Math.Round(rectangle1.GetTotalArea() + rectangle2.GetTotalArea(), 2);
        }

        public double GetTotalArea()
        {
            return 0;
        }

        public double GetTotalArea(Circle circle)
        {
            return circle.GetTotalArea();
        }

        public double GetTotalArea(Square square)
        {
            return square.GetTotalArea();
        }

        public double GetTotalArea(Rectangle rectangle)
        {
            return rectangle.GetTotalArea();
        }
    }
}
