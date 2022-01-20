using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace Press3._0
{
    public class Cx : DbContext
    {
        public DbSet<Hlass>? Main { get; set; }
        public Cx(){ }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["entityFramework"].ConnectionString);
        }


    }
}
