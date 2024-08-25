namespace Travel_App_Server.Models
{
    public class Step
    {
        public long StepId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsVisited { get; set; }

        // Relazioni
        public long? DayId { get; set; }
        public Day Day { get; set; }

        public long TripId { get; set; }
        public Trip Trip { get; set; }

        public long? PlaceId { get; set; }
        public Place Place { get; set; }

        public ICollection<Note> Notes { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }
}
