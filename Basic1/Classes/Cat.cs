using Basic1.Interfaces;

namespace Basic1.Classes
{
    public class Cat : IAnimal
    {
        public string Speak() => "Meow meow";
        public string Name { get; set; }
        public string Information { get; set; }
    }

}
