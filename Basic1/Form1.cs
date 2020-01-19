using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
    }

}
