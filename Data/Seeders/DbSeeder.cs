using Cascadia_MetalFlow_System.Data;
using Cascadia_MetalFlow_System.Enums;
using Microsoft.AspNetCore.Identity;

namespace Cascadia_MetalFlow_System.Data.Seeders
{
    public static class DbSeeder
    {
        public static async Task SeedRolesAndAdminAsync(IServiceProvider serviceProvider)
        {
            //Seed Roles
            var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            await roleManager.CreateAsync(new IdentityRole(RoleNames.Admin));
            await roleManager.CreateAsync(new IdentityRole(RoleNames.Manager));
            await roleManager.CreateAsync(new IdentityRole(RoleNames.Supervisor));
            await roleManager.CreateAsync(new IdentityRole(RoleNames.Planner));
            await roleManager.CreateAsync(new IdentityRole(RoleNames.Operator));
            await roleManager.CreateAsync(new IdentityRole(RoleNames.Driver));
            await roleManager.CreateAsync(new IdentityRole(RoleNames.BasicUser));


            // creating a default admin user
            var user = new ApplicationUser
            {
                UserName = "admin@metalkraft.com",
                Email = "admin@metalkraft.com",
                FirstName = "Admin",
                LastName = "User",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true
            };
            if (await userManager.FindByEmailAsync(user.Email) == null)
            {
                await userManager.CreateAsync(user, "Admin@123");
                await userManager.AddToRoleAsync(user, RoleNames.Admin);
            }
        }
    }
}
