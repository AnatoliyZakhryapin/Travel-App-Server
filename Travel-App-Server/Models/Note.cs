namespace Travel_App_Server.Models
{
    public class Note
    {
        public long NoteId { get; set; }
        public string Text { get; set; }

        // Relazioni
        public long StepId { get; set; }
        public Step Step { get; set; }
    }
}
