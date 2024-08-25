namespace Travel_App_Server.Models
{
    public class Review
    {
        public long ReviewId { get; set; }
        public string Message { get; set; }
        public int Rating { get; set; }

        // Relazioni
        public long? StepID { get; set; }
        public Step? Step { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }
    }
}
