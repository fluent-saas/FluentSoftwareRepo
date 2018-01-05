using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using FluentSoftware.Authorization.Roles;
using FluentSoftware.Authorization.Users;
using FluentSoftware.MultiTenancy;

namespace FluentSoftware.EntityFrameworkCore
{
    public class FluentSoftwareDbContext : AbpZeroDbContext<Tenant, Role, User, FluentSoftwareDbContext>
    {
        /* Define an IDbSet for each entity of the application */
        
        public FluentSoftwareDbContext(DbContextOptions<FluentSoftwareDbContext> options)
            : base(options)
        {
        }
    }
}
