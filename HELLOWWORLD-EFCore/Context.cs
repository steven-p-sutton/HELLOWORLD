using Microsoft.EntityFrameworkCore;

namespace HELLOWWORLD_EFCore
{
    public class Context : DbContext
    {
        public DbSet<HelloWorld> HelloWorlds { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=HelloWorld.db");
    }
}
