using Domain;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Implementation3_Web.Models;
using static Domain.Models.StatusObject;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Implementation3_Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NamesController : ControllerBase
    {
        private static List<StatusObject> _statusObjects = new ();

        // GET api/<NamesController>/5
        [HttpGet("{id}")]
        public StatusObject GetStatus(Guid id)
        {


            StatusObject statusObject = _statusObjects.FirstOrDefault(x => x.Id == id);
            statusObject.CalculateProgressPercentage();

            if(statusObject.CalculationStatus == Status.Completed)
            {
                statusObject.CalculationValues = NameCalculator.FizzBuzzCalculation(statusObject.FirstName, statusObject.LastName);
            }
            return statusObject;
        }

        // POST api/<NamesController>
        [HttpPost]
        public Guid StartCalculation(CalculationRequest req)
        {

            StatusObject statusObject = new()
            {
                Id = Guid.NewGuid(),
                FirstName = req.FirstName,
                LastName = req.LastName
            };

            _statusObjects.Add(statusObject);
            return statusObject.Id;
            
            
        }

    }
}
