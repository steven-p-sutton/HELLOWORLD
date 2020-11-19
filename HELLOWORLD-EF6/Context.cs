using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace HELLOWORLD_EF6
{
    public class Context : DbContext
    {
        public DbSet<HelloWorld> HelloWorlds { get; set; }
    }
}
