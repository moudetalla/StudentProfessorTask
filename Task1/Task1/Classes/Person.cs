using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Classes
{
    public class Person
    {

        string _name;
        int _age;

        public Person(string name)
        {
            _name = name;
        }

        public string Name { get => _name; set => _name = value; }
        public int Age { get => _age; set => _age = value; }


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
