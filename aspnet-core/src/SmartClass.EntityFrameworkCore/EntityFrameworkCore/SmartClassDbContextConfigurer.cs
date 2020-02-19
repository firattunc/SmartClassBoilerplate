using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace SmartClass.EntityFrameworkCore
{
    public static class SmartClassDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<SmartClassDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<SmartClassDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
