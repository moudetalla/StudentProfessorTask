using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Classes
{
    public class Professor : Person
    {
        public Professor(string name) : base(name)
        {
        }

        public void Explain()
        {
            Console.WriteLine("I'm explaining");
        }

    }
}
