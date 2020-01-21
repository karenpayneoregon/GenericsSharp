using Basic1.Interfaces;

namespace Basic1.Classes
{
    public class Dog : IAnimal
    {
        public string Speak() => "Bark Bark";
        public string Name { get; set; }
        public string Information { get; set; }
    }

}
