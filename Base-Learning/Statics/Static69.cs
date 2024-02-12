namespace Base_Learning.Statics
{
    public class Static69
    {
        public static string StaticField = "Sethu";    

        public static void StaticMethod()
        {
            Console.WriteLine($"Staticmethod using the staticfield {StaticField}");
        }

        public void NonStaticMethod()
        {
            Console.WriteLine("Non static method 1 is called");
        }

        public void NonStaticMethod2()
        {
            Console.WriteLine("Non static method 2 is called");
        }
    }
}
