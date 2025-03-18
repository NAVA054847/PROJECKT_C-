using Microsoft.EntityFrameworkCore;

namespace NAVA_CHAYA.Entities
{
    public class MY_DBContext:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=sample_db");
        }

        public DbSet<Persone>  Users { get; set; }

    }
}
