using Base_Learning.ClassAndObject.Model;

namespace Base_Learning.ClassAndObject
{
    public class ShapeArea
    {
        public ShapeModel shape { get; set; }
        public ShapeArea(double length, double width)
        {
            shape = new ShapeModel { Length = length, Width = width };
        }

        public double AreaCalculate()
        {
            return shape.Length * shape.Width;
        }
    }
}
