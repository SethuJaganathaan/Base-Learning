using Base_Learning.Abstract;
using Base_Learning.ClassAndObject;
using Base_Learning.ConstAndReadonly;
using Base_Learning.Shapes;
using Base_Learning.Statics;

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

    static void maain(string[] args)
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

    static void nain(string[] args)
    {
        ClassAndObj classandobj = new ClassAndObj("Shelby", 35);
        ShapeArea shapearea = new ShapeArea(50,50);
        Console.WriteLine($"Area of shape is {shapearea.AreaCalculate()}");
        classandobj.Introduce();
    }

    static void Mainn(string[] args)
    {
        Console.WriteLine(Static69.StaticField);
        Static69.StaticMethod();

        Static69 static69 = new Static69();
        static69.NonStaticMethod2();
        static69.NonStaticMethod();
    }

    static void Main(string[] args)
    {
        ConstAndReadonly constAndReadonly = new ConstAndReadonly("Cook");
        constAndReadonly.Testing();
    }
}
