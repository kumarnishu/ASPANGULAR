using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ASPANGULAR.EntityFrameworkCore
{
    public static class ASPANGULARDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ASPANGULARDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ASPANGULARDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
