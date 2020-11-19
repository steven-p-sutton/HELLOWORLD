namespace HELLOWWORLD_EF6
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<HELLOWWORLD_EF6.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "HELLOWWORLD_EF6.Context";
        }

        protected override void Seed(HELLOWWORLD_EF6.Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
