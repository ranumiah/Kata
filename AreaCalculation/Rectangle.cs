namespace AreaCalculation
{
    internal class Rectangle : ICalculateShapeArea
    {
        private double _height;
        private double _width;

        public Rectangle(double height, double width)
        {
            _height = height;
            _width = width;
        }

        public double GetTotalArea()
        {
            return _height*_width;
        }
    }
}