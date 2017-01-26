namespace AreaCalculation
{
    internal class Square : ICalculateShapeArea
    {
        private double _side;

        public Square(double side)
        {
            this._side = side;
        }

        public double GetTotalArea()
        {
            return _side*_side;
        }
    }
}