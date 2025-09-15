using Cascadia_MetalFlow_System.Models;
using Microsoft.AspNetCore.Identity;

namespace Cascadia_MetalFlow_System.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Avatar { get; set; }
        public int? CompanyBranchId { get; set; }
        public CompanyBranch? CompanyBranch { get; set; }
    }

}
