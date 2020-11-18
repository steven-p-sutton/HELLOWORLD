// Microsoft Entity Framework
//		https://docs.microsoft.com/en-us/ef/
//
//		Entity Framework 6
//			https://docs.microsoft.com/en-us/ef/ef6/
//			Get started with Entity Framework 6
//
//          Tutorial
//              https://docs.microsoft.com/en-us/ef/ef6/modeling/code-first/workflows/existing-database
//              1. Create an Existing Database
//                  https://docs.microsoft.com/en-us/ef/ef6/modeling/code-first/workflows/existing-database#1-create-an-existing-database
//              2. Create the Application
//                  https://docs.microsoft.com/en-us/ef/ef6/modeling/code-first/workflows/existing-database#2-create-the-application
//              3. Reverse Engineer Model
//                  https://docs.microsoft.com/en-us/ef/ef6/modeling/code-first/workflows/existing-database#3-reverse-engineer-model
//              4. Reading & Writing Data
//                  https://docs.microsoft.com/en-us/ef/ef6/modeling/code-first/workflows/existing-database#4-reading--writing-data
//              5Using Code First Migrations to an Existing Database
//                  https://docs.microsoft.com/en-us/ef/ef6/modeling/code-first/workflows/existing-database#using-code-first-migrations-to-an-existing-database
// 

using System;
using System.Linq;

namespace CodeFirstExistingDatabaseSample
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new BloggingContext())
            {
                // Create and save a new Blog
                Console.Write("Enter a name for a new Blog: ");
                var name = Console.ReadLine();

                var blog = new Blog { Name = name };
                db.Blogs.Add(blog);
                db.SaveChanges();

                // Display all Blogs from the database
                var query = from b in db.Blogs
                            orderby b.Name
                            select b;

                Console.WriteLine("All blogs in the database:");
                foreach (var item in query)
                {
                    Console.WriteLine(item.Name);
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
}
