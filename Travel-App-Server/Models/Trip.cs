namespace Travel_App_Server.Models
{
    public class Trip
    {
        public long TripId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime TripStart { get; set; }
        public DateTime TripEnd { get; set; }

        // Relazioni
        public long DestinationId { get; set; }
        public Destination Destination { get; set; }

        public ICollection<Day> Days { get; set; }
        public ICollection<Step> Steps { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
    }
}
