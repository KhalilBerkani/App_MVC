using AppInd.Models;
using Microsoft.EntityFrameworkCore;

namespace AppInd.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Categories> Categoriess { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Categories>().HasData(

                new Categories { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Categories { Id = 2, Name = "Horror", DisplayOrder = 2 },
                new Categories { Id = 3, Name = "Comedie", DisplayOrder = 3 }
            );
        }


    }
}
