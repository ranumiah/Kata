namespace AreaCalculation
{
    internal class Triangle : ICalculateShapeArea
    {
        private double _triangleBase;
        private double _triangleHeight;

        public Triangle(double triangleBase, double triangleHeight)
        {
            this._triangleBase = triangleBase;
            this._triangleHeight = triangleHeight;
        }

        public double GetTotalArea()
        {
            return _triangleBase*_triangleHeight/2;
        }
    }
}