namespace Travel_App_Server.Models
{
    public class Place
    {
        public long PlaceID { get; set; }
        public string Name { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public string PlaceIDGoogle { get; set; }
        public string ImageSrc { get; set; }

        // Relazioni
        public ICollection<Step> Steps { get; set; }
        public ICollection<Expense> Expenses { get; set; }
    }
}
