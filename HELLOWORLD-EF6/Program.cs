
// Microsoft Entity Framework
//		https://docs.microsoft.com/en-us/ef/

//		Entity Framework 6
//			https://docs.microsoft.com/en-us/ef/ef6/
//			Get started with Entity Framework 6
//
//          Connection strings and models
//              https://docs.microsoft.com/en-us/ef/ef6/fundamentals/configuring/connection-strings?redirectedfrom=MSDN
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
//                  https://docs.microsoft.com/en-us/ef/ef6/modeling/code-first/workflows/new-database#5-dealing-with-model-models
//                  - Edit model classes as required
//                  - Open NUGet Package Manager Console in Visual Studio
//                  - Enable-Migrations
//                  - Add-Migration <abc>
//                  - Update-Database
//
//              6. Data Annotations
//                  https://docs.microsoft.com/en-us/ef/ef6/modeling/code-first/workflows/new-database#6-data-annotations
//
//              7. Fluent API
//                  https://docs.microsoft.com/en-us/ef/ef6/modeling/code-first/workflows/new-database#7-fluent-api
//                                 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HELLOWORLD_EF6
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new Context())
            {
                // Create and save a new Blog
                var text = "Hello World!";

                var helloWorld = new HelloWorld { Text = text };
                db.HelloWorlds.Add(helloWorld);
                db.SaveChanges();

                // Display all Texts from the database
                var query = from b in db.HelloWorlds
                            orderby b.HelloWorldId
                            select b;

                Console.WriteLine("All texts in the database:");
                foreach (var item in query)
                {
                    Console.WriteLine(item.Text);
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
}
