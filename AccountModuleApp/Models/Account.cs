namespace AccountModuleApp.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public AccountType? Types { get; set; }
        public int? AccountCode { get; set; }
        public int? ParentAcccountId { get; set; }
        public Account? account { get; set; }
        public decimal? debit { get; set; }
        public decimal? credit { get; set; }
        public bool? IsDeleted { get; set; }
        public decimal? OpeningBalance { get; set; }
        public int? BranchId { get; set; }
        public Branch? BranchName { get; set; }
    }
    public enum AccountType
    {
        Assets,
        Liability,
        Revenue,
        Expense,
        Equity
    }
}
