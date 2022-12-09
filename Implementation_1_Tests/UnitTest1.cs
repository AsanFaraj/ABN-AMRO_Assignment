using Domain.Models;

namespace Implementation_1_Tests
{
    public class Tests
    {
        string firstName;
        string lastName;
        string firstNameAndLastName;
        List<CalculationValue> fizzBuzzList;


        [SetUp]
        public void Setup()
        {
            firstName = "First";
            lastName = "Last";
            firstNameAndLastName= $"{firstName} {lastName}";
            fizzBuzzList = NameCalculator.FizzBuzzCalculation(firstName, lastName);
        }

        [Test]
        public void FizzBuzzCalculation_Returns_FirstName_When_Number_Is_Divisible_By_Only_3()
        {
         
            Assert.That(firstName, Is.EqualTo(fizzBuzzList[2].IndexValue));
            Assert.That(firstName, Is.EqualTo(fizzBuzzList[5].IndexValue));
            Assert.That(firstName, Is.EqualTo(fizzBuzzList[8].IndexValue));
        }

        [Test]
        public void FizzBuzzCalculation_Returns_LastName_When_Number_Is_Divisible_By_Only_5()
        {
            Assert.That(lastName, Is.EqualTo(fizzBuzzList[4].IndexValue));
            Assert.That(lastName, Is.EqualTo(fizzBuzzList[9].IndexValue));
            Assert.That(lastName, Is.EqualTo(fizzBuzzList[19].IndexValue));
        }

        [Test]
        public void FizzBuzzCalculation_Returns_FirstNameAndLastName_When_Number_Is_Divisible_By_3_And_5()
        {
            Assert.That(firstNameAndLastName, Is.EqualTo(fizzBuzzList[14].IndexValue));
            Assert.That(firstNameAndLastName, Is.EqualTo(fizzBuzzList[29].IndexValue));
            Assert.That(firstNameAndLastName, Is.EqualTo(fizzBuzzList[44].IndexValue));
        }

        [Test]
        public void FizzBuzzCalculation_Returns_Number_When_Number_Is_Not_Divisible_By_3_Or_5()
        {
            Assert.That("1", Is.EqualTo(fizzBuzzList[0].IndexValue));
            Assert.That("7", Is.EqualTo(fizzBuzzList[6].IndexValue));
            Assert.That("17", Is.EqualTo(fizzBuzzList[16].IndexValue));
        }

        [Test]
        public void FizzBuzzCalculation_Should_Return_Count_Of_100()
        {
            Assert.That(100, Is.EqualTo(fizzBuzzList.Count));
           
        }


    }
}