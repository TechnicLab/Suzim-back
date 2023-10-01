using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Suzim.Store.Postgres;

public sealed class IdentityContextPostgres : IdentityDbContext<IdentityUser>
{
    public IdentityContextPostgres(DbContextOptions<IdentityContextPostgres> options)
        : base(options)
    {
        
    }
}