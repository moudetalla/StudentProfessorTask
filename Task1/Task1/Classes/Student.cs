using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Classes
{
    public class Student : Person
    {
        public Student(string name) : base(name)
        {
        }

        public void Study()
        {
            Console.WriteLine("I'm studying");

        }

        public string ShowAge()
        {
            var myAge = $"My age is: {this.Age} years old";
            Console.WriteLine(myAge);
            return myAge;

        }
    }
}
