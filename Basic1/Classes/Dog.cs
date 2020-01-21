using System.Collections.Generic;
using Basic1.Interfaces;

namespace Basic1.Classes
{
    public class Dog : IAnimal
    {
        public string Speak() => "Bark Bark";
        public string Name { get; set; }
        public string Information { get; set; }

        protected bool Equals(Dog other)
        {
            return string.Equals(Name, other.Name);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Dog) obj);
        }

        public override int GetHashCode()
        {
            return (Name != null ? Name.GetHashCode() : 0);
        }


    }

}
