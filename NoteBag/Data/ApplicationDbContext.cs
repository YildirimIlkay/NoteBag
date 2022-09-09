using Microsoft.EntityFrameworkCore;

namespace NoteBag.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options ):base(options)
        {

        }
        public DbSet<Note> Notes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Note>().HasData(
                new Note()
                {
                    Id = 1,
                    Title = "Lorem Ipsum",
                    Content = "Lorem Lorem Lorem Lorem Lorem"
                },
                new Note()
                {
                    Id = 2,
                    Title = "Dolor Sit",
                    Content = "Lorem Lorem Lorem Lorem Lorem"
                },
                new Note()
                {
                    Id = 3,
                    Title = "Amet ",
                    Content = "Lorem Lorem Lorem Lorem Lorem"
                }
                );
        }
    }
}
