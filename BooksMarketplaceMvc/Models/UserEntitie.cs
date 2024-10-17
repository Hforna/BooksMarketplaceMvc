using Microsoft.AspNetCore.Identity;

namespace BooksMarketplaceMvc.Models
{
    public class UserEntitie : IdentityUser<long>
    {
        public bool Active { get; set; } = true;
        public DateTime CreatedOn { get; set; }
        public string? Password { get; set; }
        public Guid UserIdentifier { get; set; }
        public string? ImageIdentifier { get; set; }
    }
}
