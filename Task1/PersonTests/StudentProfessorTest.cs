using Task1.Classes;
using Xunit;

namespace PersonTests
{
    public class StudentProfessorTest
    {
        [Fact]
        public void PersonTest_SayHello()
        {

            //Arrange
            var person = new Person("Mohammad");


            //Act

            var result = person.Greet();

            //Assert
            Assert.Equal($"Hello {person.Name}", result);


        }

        [Fact]
        public void StudentTest_SayHelloToStudent()
        {
            var student = new Student("Ahmad");
            


            var nameResult = student.Greet();


            
            Assert.Equal($"Hello {student.Name}", nameResult);


        }


        [Fact]
        public void StudentTest_PrintTheAge()
        {
            var student = new Student("Ahmad");
            student.SetAge(18);


            var result = student.ShowAge();
            


            Assert.Equal($"My age is: {student.Age} years old", result);
            


        }



        [Fact]
        public void ProfessorTest_SayHelloToProfessor()
        {
            var prof = new Professor("Saleh");

            


            
            var nameResult = prof.Greet();

            
            Assert.Equal($"Hello {prof.Name}", nameResult);




        }


        [Fact]
        public void ProfessorTest_PrintTheAge()
        {
            var prof = new Professor("Saleh");

            prof.SetAge(48);


            var result = prof.Age;
            

            Assert.Equal(48, result);
            




        }
    }
}
