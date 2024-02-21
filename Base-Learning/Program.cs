using Base_Learning.Abstract;
using Base_Learning.Basic_Program;
using Base_Learning.ClassAndObject;
using Base_Learning.ConstAndReadonly;
using Base_Learning.Shapes;
using Base_Learning.Statics;

class Program
{
    // area of shape normal
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
    // area of shape loop
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
    // static example
    static void Mainn(string[] args)
    {
        Console.WriteLine(Static69.StaticField);
        Static69.StaticMethod();

        Static69 static69 = new Static69();
        static69.NonStaticMethod2();
        static69.NonStaticMethod();
    }

    //static and readonly example
    static void Maiiin(string[] args)
    {
        ConstAndReadonly constAndReadonly = new ConstAndReadonly("Cook");
        constAndReadonly.Testing();
    }

    // remove duplicates
    static void Madin(string[] args)
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();
        string result = new string(input.Distinct().ToArray());
        Console.WriteLine("String with duplicates removed: " + result);
    }

    //VowelCheck
    static void Maipn(string[] args)
    {

        Vowel vowel = new Vowel();

        for(int i = 0; true; i++)
        {
            Console.WriteLine("Press Q to quit");
            Console.WriteLine("Enter the letter");
            char letter = Console.ReadKey().KeyChar;

            if(letter == 'Q')
            {
                Console.WriteLine("Existing the program");
                break;
            }

            if (vowel.VowelCheck(letter))
            {
                Console.WriteLine("Its a Vowel");
            }
            else
            {
                Console.WriteLine("Not a vowel");
            }
        }
        
    }

    // primenumber check
    static void Main(string[] args)
    {
        for(int i = 0; true; i++)
        {
            Console.WriteLine("Enter the number to check");
            int number = Convert.ToInt32(Console.ReadLine());

            PrimeNumber prime = new PrimeNumber();

            if(prime.PrimeCheck(number))
            {
                Console.WriteLine($"{number} is a prime");
            }
            else
            {
                Console.WriteLine($"{number} is not a prime");
            }
        }
    }
}
