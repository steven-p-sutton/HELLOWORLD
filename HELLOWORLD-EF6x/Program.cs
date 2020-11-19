using System;
using System.Linq;

// Microsoft Entity Framework
//		https://docs.microsoft.com/en-us/ef/

//		Entity Framework 6
//			https://docs.microsoft.com/en-us/ef/ef6/
//			Get started with Entity Framework 6
//
//          Tutorial
//              https://docs.microsoft.com/en-us/ef/ef6/modeling/code-first/workflows/new-database
//
//              1. Create the Application
//                  https://docs.microsoft.com/en-us/ef/ef6/modeling/code-first/workflows/new-database#1-create-the-application
//              
//                  Database is created in SQLExpress when app is run first time
//                  (LocalDb)\MSSQLLocalDB
//
//                      VS2019/Server Explorer
//                                SERVER = laptop-qr0qpgvq\localdb#ec7f3d87.master.dbo (enterd as (LocalDB)\MSSQLLocalDB
//                      CONNECTIONSTRING = Data Source=(LocalDb)\MSSQLLocalDB;Integrated Security=True
//                      SSMS
//                                SERVER = LAPTOP - QR0QPGVQ\LOCALDB#631D7789
//                                    DB = CodeFirstNewDatabaseSample.BloggingContext

//                       MSSQL
//                                    DB = LAPTOP-QR0QPGVQ
//                      CONNECTIONSTRING = Data Source=LAPTOP-QR0QPGVQ;Integrated Security=True
//
//              2. Create the Model
//                  https://docs.microsoft.com/en-us/ef/ef6/modeling/code-first/workflows/new-database#2-create-the-model
//
//              3. Create a Context
//                  https://docs.microsoft.com/en-us/ef/ef6/modeling/code-first/workflows/new-database#3-create-a-context
//
//              4. Reading & Writing Data
//                  https://docs.microsoft.com/en-us/ef/ef6/modeling/code-first/workflows/new-database#4-reading--writing-data
//
//              5. Dealing with Model Changes
//                  https://docs.microsoft.com/en-us/ef/ef6/modeling/code-first/workflows/new-database#5-dealing-with-model-changes
//
//              6. Data Annotations
//                  https://docs.microsoft.com/en-us/ef/ef6/modeling/code-first/workflows/new-database#6-data-annotations
//
//              7. Fluent API
//                  https://docs.microsoft.com/en-us/ef/ef6/modeling/code-first/workflows/new-database#7-fluent-api
//                                 

namespace HELLOWWORLD_EF6
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
                db.HelloWorlds.Add(new HelloWorld { Text = "Hello World !" });
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
                db.HelloWorlds.Remove(helloWorld);
                db.SaveChanges();
            }
        }
    }
}
