using Dapper;
using Domain.Models;
using System.Data.SqlClient;

namespace Implementation2_Web.Services
{
    public class FizzBuzzService
    {
        private static string connectionString;

        private static string storedProcedure = "FizzBuzzCalculationSP";

        public FizzBuzzService(IConfiguration config)
        {

            connectionString = config.GetConnectionString("Default");

            //Make sure your connection string points to the same database name you gave when publishing the database project
            ArgumentNullException.ThrowIfNull(connectionString);

        }

        public async Task<IEnumerable<CalculationValue>> GetFizzBuzzValues()
        {

            using var connection = new SqlConnection(connectionString);

            var fizzBuzzValues = await connection.QueryAsync<CalculationValue>("select index_number IndexNumber, index_value IndexValue from FizzBuzzValues");

            return fizzBuzzValues;
        }

        public async Task CalculateFizzBuzzValues(string firstNameParam, string lastNameParam)
        {
            using var connection = new SqlConnection(connectionString);

            var values = new {firstName = firstNameParam, lastName = lastNameParam};

            await connection.ExecuteAsync(storedProcedure,values,commandType:System.Data.CommandType.StoredProcedure);

        }




    }
}
