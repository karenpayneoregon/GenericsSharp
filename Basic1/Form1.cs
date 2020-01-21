using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Basic1.Classes;
using Basic1.Extensions;
using static System.DateTime;

namespace Basic1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }
        /// <summary>
        /// Comparable.CompareTo wrapper in language extension
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IComparableButton_Click(object sender, EventArgs e)
        {
            int lowIntValue = 4;
            int betweenIntValue = 5;
            int highIntValue = 7;

            Console.WriteLine("Conventional int between");
            if (betweenIntValue.CompareTo(lowIntValue) >= 0 && betweenIntValue.CompareTo(highIntValue) <0)
            {
                Console.WriteLine($"{betweenIntValue} is between {lowIntValue} and {highIntValue}");
            }
            else
            {
                Console.WriteLine($"{betweenIntValue} is not between {lowIntValue} and {highIntValue}");
            }

            Console.WriteLine("Generic int between");
            if (betweenIntValue.Between(lowIntValue, highIntValue))
            {
                Console.WriteLine($"{betweenIntValue} is between {lowIntValue} and {highIntValue}");
            }
            else
            {
                Console.WriteLine($"{betweenIntValue} is not between {lowIntValue} and {highIntValue}");
            }

            Console.WriteLine();
            Console.WriteLine("Conventional date between");

            DateTime lowDateTime = new DateTime(Now.Year,Now.Month,16);
            DateTime betweenDateTime = new DateTime(Now.Year, Now.Month, 18);
            DateTime highDateTime = new DateTime(Now.Year, Now.Month, 20);

            if (betweenDateTime.CompareTo(lowDateTime) >= 0 && betweenDateTime.CompareTo(highDateTime) < 0)
            {
                Console.WriteLine($"{betweenIntValue} is between {lowDateTime} and {highDateTime}");
            }
            else
            {
                Console.WriteLine($"{betweenIntValue} is not between {lowIntValue} and {highIntValue}");
            }

            Console.WriteLine("Generic date between");
            if (betweenDateTime.Between(lowDateTime, highDateTime))
            {
                Console.WriteLine($"{betweenDateTime:d} is between {lowDateTime:d} and {highDateTime:d}");
            }
            else
            {
                Console.WriteLine($"{betweenDateTime:d} is not between {lowDateTime:d} and {highDateTime:d}");
            }
        }

        private void SimpleInterfaceButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Non class example");
            var person = new Person();
            Console.WriteLine($"\tPerson says {person.Speak()}");

            var dog = new Dog();
            Console.WriteLine($"\tDog says {dog.Speak()}");

            var cat = new Cat();
            Console.WriteLine($"\tCat says {cat.Speak()}");

            Console.WriteLine("Generic class example");

            var personDemo = new AnimalGenericClass<Person>();
            personDemo.CallThisMethodWhateverYouWant();

            var dogDemo = new AnimalGenericClass<Dog>();
            dogDemo.CallThisMethodWhateverYouWant();

            var catDemo = new AnimalGenericClass<Cat>();
            catDemo.CallThisMethodWhateverYouWant();

            Console.WriteLine("Generic class example with generic property");

            var p1 = new AnimalGenericClass<Person, string>{GenericVariable = "John"};
            Console.WriteLine($"\t{p1.GenericVariable}");
            var d1 = new AnimalGenericClass<Dog, string> { GenericVariable = "Fiddo" };
            Console.WriteLine($"\t{d1.GenericVariable}");
            var c1 = new AnimalGenericClass<Cat, string> { GenericVariable = "Kitty" };
            Console.WriteLine($"\t{c1.GenericVariable}");

            Console.WriteLine();

            var p2 = new AnimalGenericClass<Person, string>() ;
            
            p2.SampleProcedure("Works at John's coffee shop");
            Console.WriteLine(p2);

        }
    }

}
