using System.Collections.Generic;
using Basic1.Interfaces;

namespace Basic1.Classes
{
    public class Cat : IAnimal
    {
        public string Speak() => "Meow meow";
        public string Name { get; set; }
        public string Information { get; set; }

        protected bool Equals(Cat other)
        {
            return string.Equals(Name, other.Name);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Cat) obj);
        }

        public override int GetHashCode()
        {
            return (Name != null ? Name.GetHashCode() : 0);
        }


    }

}
