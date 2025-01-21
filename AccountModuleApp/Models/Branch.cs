namespace AccountModuleApp.Models
{
    public class Branch
    {
        public int Id { get; set; }
        public string? BranchName { get; set; }
        public string? BranchCode { get; set; }
        public string? BranchLocation { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}
