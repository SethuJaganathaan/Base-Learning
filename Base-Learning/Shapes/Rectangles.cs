namespace Base_Learning.Shapes
{
    public class Rectangles : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangles(double width, double height)
        {
            Width = width;
            Height = height;
        }
        public double CalculateArea()
        {
            return Width * Height;
        }
    }
}
