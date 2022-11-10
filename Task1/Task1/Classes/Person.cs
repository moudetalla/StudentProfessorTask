using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Classes
{
    public class Person
    {

        

        public Person(string name)
        {
            Name = name;
        }

        public string Name { get ; set; }
        public int Age { get; set; }


        public void SetAge(int age)
        {
            this.Age = age;
        }

        public string Greet()
        {

            string hi = $"Hello {this.Name}";
            Console.WriteLine(hi);
            return hi;
        }
    }
}
