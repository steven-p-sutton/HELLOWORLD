using System.Data.Entity;

namespace HELLOWWORLD_EF6
{
    public class Context : DbContext
    {
        public Context()
            : base("name=Context")
        {
        }
        public DbSet<HelloWorld> HelloWorlds { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //    => options.UseSqlite("Data Source=HelloWorld.db");
    }
}
