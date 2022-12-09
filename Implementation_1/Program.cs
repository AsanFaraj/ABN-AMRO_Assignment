using Domain;
using Domain.Models;

Console.WriteLine("What is your first name?");
var firstName = Console.ReadLine();

Console.WriteLine("What is your last name?");
var lastName = Console.ReadLine();


List<CalculationValue> myList = NameCalculator.FizzBuzzCalculation(firstName, lastName);

foreach (var item in myList)
{
    Console.WriteLine($"{item.IndexNumber} = {item.IndexValue}");
}

