using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using FluentSoftware.Configuration;
using FluentSoftware.Web;

namespace FluentSoftware.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class FluentSoftwareDbContextFactory : IDesignTimeDbContextFactory<FluentSoftwareDbContext>
    {
        public FluentSoftwareDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<FluentSoftwareDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            FluentSoftwareDbContextConfigurer.Configure(builder, configuration.GetConnectionString(FluentSoftwareConsts.ConnectionStringName));

            return new FluentSoftwareDbContext(builder.Options);
        }
    }
}
