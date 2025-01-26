using AccountModuleApp.Data;
using AccountModuleApp.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections;

namespace AccountModuleApp.Services
{
    public class BranchService
    {
        private readonly AppDbContext appDbContext;
        public BranchService(AppDbContext context)
        {
            appDbContext = context;
        }

        public async Task<bool> AddUpdateBranch(Branch branch)
        {
            try
            {
                if (branch.Id == 0 || branch.Id == null)
                {
                    await appDbContext.branches.AddAsync(branch);
                    await appDbContext.SaveChangesAsync();
                    return true;
                }
                else if (branch.Id != null)
                {
                    appDbContext.branches.Update(branch);
                    await appDbContext.SaveChangesAsync();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public async Task<IEnumerable<Branch>> GetBranchList()
        {
            return await appDbContext.branches.ToListAsync();
        }
    }
}
