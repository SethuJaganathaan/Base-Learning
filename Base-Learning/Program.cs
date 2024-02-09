using Base_Learning.Abstract;
using Base_Learning.Shapes;
using System.Drawing;

class Program
{
    static void main(string[] args)
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

    static void Main(string[] args)
    {
        ARectangle aRect = new ARectangle(10, 20);
        ACircle aCircle = new ACircle(3);

        IAlphaShape[] Ashapes = { aRect, aCircle };
        foreach (var shape in Ashapes)
        {
            shape.PrintDescription();
            Console.WriteLine($"Area : {shape.CalculateArea()}");
        }
    }
}
