namespace Travel_App_Server.Models
{
    public class Day
    {
        public long DayId { get; set; }
        public DateTime Date { get; set; }

        // Relazioni
        public long TripId { get; set; }
        public Trip Trip { get; set; }
        public ICollection<Step> Steps { get; set; }
    }
}
