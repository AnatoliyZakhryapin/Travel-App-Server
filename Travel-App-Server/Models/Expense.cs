namespace Travel_App_Server.Models
{
    public class Expense
    {
        public long ExpenseId { get; set; }
        public decimal Cost { get; set; }
        public int Persons { get; set; }

        // Relazioni
        public long PlaceId{ get; set; }
        public Place Place { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }
    }
}
