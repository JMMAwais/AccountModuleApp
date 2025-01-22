using AccountModuleApp.Data;

namespace AccountModuleApp.Services
{
    public class AccountService
    {
        private readonly AppDbContext appDbContext;
        public AccountService(AppDbContext context)
        {
            appDbContext = context;
        }

        public async Task<bool> AddAccount()
        {
            return true;
        }
    }
}
