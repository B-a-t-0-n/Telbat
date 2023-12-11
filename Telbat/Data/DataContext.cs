using Microsoft.EntityFrameworkCore;

namespace Telbat.Data
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=DbTelbat;Trusted_Connection=True;");
        }

    }
}
