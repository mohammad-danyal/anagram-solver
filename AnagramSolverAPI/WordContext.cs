using AnagramSolverAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AnagramSolverAPI
{
    public class WordContext : DbContext
    {
        public WordContext(DbContextOptions<WordContext> options) : base(options) { }
        public DbSet<WordModel> Words { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WordModel>()
                .HasNoKey();
        }
    }
}
