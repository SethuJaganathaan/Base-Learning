namespace Base_Learning.DependencyInjection
{
    public class Depend : IDepend
    {
        private readonly Guid _id;
        public Depend()
        {
            _id = Guid.NewGuid();
            Console.WriteLine($"MyDepend is created with instance {_id}");
        }

        public void PrintMessgage()
        {
            Console.WriteLine($"Message from Depend {_id}");
        }
    }
}
