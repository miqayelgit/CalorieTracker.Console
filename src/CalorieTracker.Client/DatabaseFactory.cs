using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace CalorieTracker.Client
{
    internal class DatabaseFactory : IDesignTimeDbContextFactory<DatabaseContext>
    {
        public DatabaseContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DatabaseContext>();

            optionsBuilder.UseSqlServer(
                "Data Source=SRV-SQL16-2D;Initial Catalog=db_myCar_Internship;User ID=usr_myCar_Internship;Password=75x9Ec4ECn5hS7ScawLnNEE4;Trusted_Connection=False;Encrypt=True;TrustServerCertificate=True");

            return new DatabaseContext(optionsBuilder.Options);
        }
    }
}