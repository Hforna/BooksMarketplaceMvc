using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BooksMarketplaceMvc.Models.DataEntity
{
    public class ProjectDbContext : IdentityDbContext<UserEntitie, RoleEntitie, long>
    {
        public ProjectDbContext(DbContextOptions<ProjectDbContext> options) : base(options) { }

        public override DbSet<UserEntitie> Users {  get; set; }
    }
}
