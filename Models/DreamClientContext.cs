using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DreamClient.Models
{
    public class DreamClientContext : IdentityDbContext<ApplicationUser>
    {

    }
}