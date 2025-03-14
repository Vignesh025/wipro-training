using Microsoft.AspNetCore.Identity;

namespace role_based_auth_demo.Models
{
    public class RoleInitializer
    {
        public static async Task SeedRolesAndUsersAsync(IServiceProvider serviceProvider)
        {
            var userManager = serviceProvider.GetRequiredService<UserManager<IdentityUser>>();
            var user = await userManager.FindByEmailAsync("admin@example.com");
            await userManager.AddToRoleAsync(user, "Admin");
        }
    }
}
