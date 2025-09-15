using Cascadia_MetalFlow_System.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Cascadia_MetalFlow_System.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<CompanyBranch> CompanyBranches { get; set; }
        public DbSet<Machine> Machines { get; set; }
        public DbSet<DeliveryTruck> DeliveryTrucks { get; set; }
    }
}
