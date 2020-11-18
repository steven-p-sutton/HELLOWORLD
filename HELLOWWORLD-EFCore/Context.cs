using Microsoft.EntityFrameworkCore;

namespace HELLOWWORLD_EFCore
{
    public class Context : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=HelloWorld.db");
    }
}
