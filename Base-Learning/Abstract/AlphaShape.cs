namespace Base_Learning.Abstract
{
    public abstract class AlphaShape : IAlphaShape
    {
        public abstract double CalculateArea();

        public void PrintDescription()
        {
            Console.WriteLine($"This is {GetType().Name}");
        }
    }

    public class ARectangle : AlphaShape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public ARectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
        public override double CalculateArea()
        {
            return Width * Height;
        }
    }

    public class ACircle : AlphaShape
    {
        public double Radius { get; set; }
        public ACircle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
