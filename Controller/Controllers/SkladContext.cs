using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Model.ObjModel;

namespace Controller.Controllers
{
    internal class SkladContext : DbContext
    {
        public SkladContext(): base("DBConnection") { }
        public DbSet<Product> Products { get; set; }
        public DbSet<SI> SIs { get; set; }

    }
}
