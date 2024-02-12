namespace Base_Learning.ConstAndReadonly
{
    public class ConstAndReadonly
    {
        public const string Name = "Sanji";

        public readonly string Special;
        public ConstAndReadonly(string special)
        {
            Special = special;
        }

        public void Testing()
        {
            Console.WriteLine($"Readonly value is {Special}");
            Console.WriteLine($"Const value is {Name}");
        }
    }
}
