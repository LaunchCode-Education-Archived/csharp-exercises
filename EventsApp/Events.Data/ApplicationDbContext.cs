using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Events.Data
{
    

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public IDbSet<Event>Events { get; set; }

        public IDbSet<Comment>Comments { get; set; }

        
    }
}