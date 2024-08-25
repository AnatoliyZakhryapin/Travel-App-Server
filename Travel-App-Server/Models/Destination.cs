namespace Travel_App_Server.Models
{
    public class Destination
    {
        public long DestinationId { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }

        // Relazione con Trips
        public ICollection<Trip> Trips { get; set; }
    }
}
