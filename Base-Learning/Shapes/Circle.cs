namespace Base_Learning.Shapes
{
    public class Circle : IShape
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public double CalculateArea()
        {
            return 3.14 * Radius * Radius;
        }
    }
}
