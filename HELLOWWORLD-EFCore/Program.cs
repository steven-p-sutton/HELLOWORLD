using System;
using System.Linq;
// 
// Migrations Overview - Migrstion using cmd line
//   https://docs.microsoft.com/en-us/ef/core/managing-schemas/migrations/?tabs=dotnet-core-cli
//
//   1. Build the model in code
//   2. Create the db using migration
//      - dotnet ef migrations add InitialCreate
//      - dotnet ef database update
//   3. Revise the model in code 
//   4. Upgrade the db using migration
//      - dotnet ef migrations add <abc>
//      - dotnet ef database update
//   5. Repeat code -> upgrade steps as required
//   6. Copy db from source folder to deployment folder before running, else exceptions will occur 
//      (cant fins db so new blank created and tables are seen as missing, exception rised by app)
// SQLite Viewer Download - use to view the blogging.db created by the migration
//   https://www.systoolsgroup.com/sqlite-viewer.html
//
// References
//
//   SqliteDbContextOptionsBuilderExtensions.UseSqlite Method
//      https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.sqlitedbcontextoptionsbuilderextensions.usesqlite?view=efcore-5.0
//   C# (CSharp) DbContextOptionsBuilder.UseSqlite Examples
//      https://csharp.hotexamples.com/examples/-/DbContextOptionsBuilder/UseSqlite/php-dbcontextoptionsbuilder-usesqlite-method-examples.html

namespace HELLOWWORLD_EFCore
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            using (var db = new Context())
            {
                // Create
                Console.WriteLine("Inserting a new message");
                db.Add(new HelloWorld { Text = "Hello World !" });
                db.SaveChanges();

                // Read
                Console.WriteLine("Querying for a message");
                var helloWorld = db.HelloWorlds
                    .OrderBy(h => h.HelloWorldId)
                    .First();
                Console.WriteLine(helloWorld.Text);

                // Update
                Console.WriteLine("Updating the blog and adding a post");
                helloWorld.Text = "Hello Again World !";
                db.SaveChanges();

                // Delete
                Console.WriteLine("Delete the blog");
                db.Remove(helloWorld);
                db.SaveChanges();
            }
        }
    }
}
