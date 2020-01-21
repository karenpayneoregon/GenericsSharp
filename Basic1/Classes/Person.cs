using Basic1.Interfaces;

namespace Basic1.Classes
{
    public class Person : IAnimal
    {
        public string Speak() => "Hello";
        public string Name { get; set; }
        public string Information { get; set; }
    }
}
