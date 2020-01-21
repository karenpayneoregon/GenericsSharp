using System;
using System.Collections.Generic;
using Basic1.Interfaces;

namespace Basic1.Classes
{
    /// <summary>
    /// T must implement IAnimal
    /// 
    /// new()  lets the compiler know that any type argument supplied must have an accessible parameterless constructor
    /// The new constraint specifies that a type argument in a generic class declaration must have a public parameterless
    /// constructor. To use the new constraint, the type cannot be abstract.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class AnimalGenericClass<T> where T : IAnimal, new()
    {
        public void CallThisMethodWhateverYouWant()
        {
            T item = new T();
            Console.WriteLine($"\t{item.Speak()}");
        }
    }
    public class AnimalGenericClass<TEntity, TVariable> where TEntity : IAnimal, new()
    {
        public void CallThisMethodWhateverYouWant()
        {
            TEntity item = new TEntity();
            Console.WriteLine($"\t{item.Speak()}");
        }
        
        public void SampleProcedure(string information)
        {
            GenericVariable = (TVariable) Convert.ChangeType(information, typeof(TVariable));
        }

        public TVariable GenericVariable {get;set;}





        public override string ToString()
        {
            return $"{GenericVariable}";
        }
    }

}