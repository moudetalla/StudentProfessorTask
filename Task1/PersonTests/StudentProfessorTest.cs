using Task1.Classes;
using Xunit;

namespace PersonTests
{
    public class StudentProfessorTest
    {
        [Fact]
        public void PersonSayHi()
        {

            //Arrange
            var person = new Person("Mohammad");


            //Act

            var result = person.Greet();

            //Assert
            Assert.Equal(result, $"Hello {person.Name}");


        }




        [Fact]
        public void StudentTest()
        {
            var student = new Student("Ahmad");
            student.SetAge(18);


            var result = student.ShowAge();
            var nameResult = student.Greet();


            Assert.Equal(result, $"My age is: {student.Age} years old");
            Assert.Equal(nameResult, $"Hello {student.Name}");


        }




        [Fact]
        public void ProfessorTest()
        {
            var prof = new Professor("Saleh");

            prof.SetAge(48);


            var result = prof.Age;
            var nameResult = prof.Greet();

            Assert.Equal(result, 48);
            Assert.Equal(nameResult, $"Hello {prof.Name}");




        }
    }
}
