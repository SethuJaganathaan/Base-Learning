using Base_Learning.Shapes;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        Rectangles rect = new Rectangles(10, 10);
        Circle circle = new Circle(2);

        //double cir = circle.CalculateArea();
        //double rects = rect.CalculateArea();
        //Console.WriteLine(rects);
        //Console.WriteLine(cir);

        IShape[] shapes = new IShape[] { rect, circle };
        foreach (var shape in shapes)
        {
            Console.WriteLine($"Area: {shape.CalculateArea()}");
        }
    }
}
