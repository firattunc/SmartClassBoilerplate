using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using SmartClass.Configuration;
using SmartClass.Web;

namespace SmartClass.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class SmartClassDbContextFactory : IDesignTimeDbContextFactory<SmartClassDbContext>
    {
        public SmartClassDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<SmartClassDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            SmartClassDbContextConfigurer.Configure(builder, configuration.GetConnectionString(SmartClassConsts.ConnectionStringName));

            return new SmartClassDbContext(builder.Options);
        }
    }
}
