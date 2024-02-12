namespace Base_Learning.ClassAndObject
{
    public class ClassAndObj
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public ClassAndObj(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Introduce()
        {
            Console.WriteLine($"Name is {Name} and age is {Age}");
        }
    }
}
