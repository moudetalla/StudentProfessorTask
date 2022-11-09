using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Classes;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var person = new Person("person");
            person.Greet();



            var student = new Student("student");
            student.SetAge(18);
            student.Greet();
            student.ShowAge();


            var prof = new Professor("professor");
            prof.SetAge(48);
            prof.Greet();

            prof.Explain();


            Console.Read();


        }
    }
}
