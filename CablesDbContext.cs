using System;
using System.Data.Entity;
using System.Linq;

namespace CablesConnectingDepartment
{
    public class CablesDbContext : DbContext
    {

        public CablesDbContext()
            : base("name=CablesDbContext")
        {
        }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<CableType> CableType { get; set; }
        public DbSet<CableList> CableList { get; set; }
    }

}