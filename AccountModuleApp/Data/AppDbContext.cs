using AccountModuleApp.Models;
using Microsoft.EntityFrameworkCore;

namespace AccountModuleApp.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Branch> branches { get; set; }
        public DbSet<JournalEntry> journalEntry { get; set; }
        public DbSet<JournalEntryItem> journalEntryItems { get; set; }
    }
}
