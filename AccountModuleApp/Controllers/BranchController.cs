using AccountModuleApp.Models;
using AccountModuleApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace AccountModuleApp.Controllers
{
    public class BranchController : Controller
    { 
        private readonly BranchService _branchService;
        public BranchController(BranchService branchService)
        {
            _branchService = branchService; 
        }
        public async Task<IActionResult> AddBranch(Branch branch)
        {
            await _branchService.AddUpdateBranch(branch);
            return View();
        }

    }
}
