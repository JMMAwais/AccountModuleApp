namespace AccountModuleApp.Models
{
    public class JournalEntry
    {
        public int Id { get; set; }
        public DateOnly? date { get; set; }
        public string? Description { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
