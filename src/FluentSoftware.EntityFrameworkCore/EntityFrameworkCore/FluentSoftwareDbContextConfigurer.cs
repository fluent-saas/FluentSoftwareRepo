using System.Configuration;
using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace FluentSoftware.EntityFrameworkCore
{
    public static class FluentSoftwareDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<FluentSoftwareDbContext> builder, string connectionString)
        {
            //builder.UseSqlServer(connectionString);
            builder.UseMySql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<FluentSoftwareDbContext> builder, DbConnection connection)
        {
            //builder.UseSqlServer(connection);
            builder.UseMySql(connection);
        }
    }
}
