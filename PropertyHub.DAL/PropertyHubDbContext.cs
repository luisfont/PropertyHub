using Microsoft.AspNet.Identity.EntityFramework;
using PropertyHub.Models.Identity;

namespace PropertyHub.DAL
{
    public class PropertyHubDbContext : IdentityDbContext<ApplicationUser>
    {
        public PropertyHubDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static PropertyHubDbContext Create()
        {
            return new PropertyHubDbContext();
        }
    }
}
