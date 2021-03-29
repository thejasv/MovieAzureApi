using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AzureDatabasedeploy.Models
{
    public class MovieContext:DbContext
    {
        public MovieContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Movie> Movies { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(
                new Movie
                {
                    Id = 1,
                    Name = "xman",
                    Description = "good",
                    Duration = 2.05f
                });
        }
    }
}
