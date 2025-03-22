using Microsoft.EntityFrameworkCore;

namespace NAVA_CHAYA.Entities
{
    public class MY_DBContext:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
          // optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=sample_db");

         //  optionsBuilder.UseSqlServer(@"Server=DESKTOP-P6FFS03\SQLEXPRESS;Database=sample_db;Trusted_Connection=True;");
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-P6FFS03\SQLEXPRESS;Database=sample_db;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        public DbSet<Persone>  Users { get; set; }

    }
}
