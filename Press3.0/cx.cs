using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace Press3._0
{
    public class cx : DbContext
    {
        public DbSet<Hlass> Main { get; set; }
        //public cx()
        //    : base("name=PressureEntities")
        //{
        //}
        public cx()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["entityFramework"].ConnectionString);
        }


    }
}
