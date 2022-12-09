using Domain.Models;
using System.Text;

namespace Domain

{
    public static class NameCalculator
    {



        public static List<CalculationValue> FizzBuzzCalculation(string firstName, string lastName)
        {
            List<CalculationValue> list = new();

            for (int i = 1; i <= 100; i++)
            {
                CalculationValue value = new()
                {
                    IndexNumber = i
                };

                if (i % 3 == 0 && i % 5 == 0)
                {
                    value.IndexValue = $"{firstName} {lastName}";
                }

                else if (i % 3 == 0)
                {
                    value.IndexValue = firstName;

                }
                else if (i % 5 == 0)
                {
                    value.IndexValue = lastName;

                }
                else
                {
                    value.IndexValue = i.ToString();
                }
                list.Add(value);
            }
            return list;
        }

    }
}