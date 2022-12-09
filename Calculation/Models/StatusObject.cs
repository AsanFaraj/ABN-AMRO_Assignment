using System.Text.Json.Serialization;

namespace Domain.Models
{
    public class StatusObject
    {


        public Guid Id { get; init; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public List<CalculationValue> CalculationValues { get; set; } = new();

        public double Progress { get; set; }


        public Status CalculationStatus { get; set; } = Status.Running;

        public DateTime StartTime { get; set; } = DateTime.Now;

        public int DurationInSeconds { get; set; } = Random.Shared.Next(20, 61);

        public string StatusString => CalculationStatus switch
        {
            Status.Failed => "Failed",
            Status.Running => "Running",
            Status.Completed => "Completed",
            _ => "Error"
        };

        public DateTime EndTime => StartTime.AddSeconds(DurationInSeconds);

        public void CalculateProgressPercentage()
        {
            //Return when calculation has already failed or completed
            if (CalculationStatus == Status.Failed || CalculationStatus == Status.Completed)
            {
                return;
            }

            double progress =  Math.Ceiling(((DateTime.Now - StartTime) / (StartTime.AddSeconds(DurationInSeconds) - StartTime)) * 100);

            if (progress < 100)
            {
                //Random number between 1 and 10. If the random number equals 1, the calculation will fail
                var randomFailureChance = Random.Shared.Next(1, 11);
                Progress = progress;
                if (randomFailureChance == 1)
                {
                    CalculationStatus = Status.Failed;
                    DurationInSeconds = 0;
                }

            }
            else if (progress >= 100)
                {
                    CalculationStatus = Status.Completed;
                    Progress = 100;
                }

        }


        public enum Status
        {
            Failed,
            Running,
            Completed
        }
    }
}

