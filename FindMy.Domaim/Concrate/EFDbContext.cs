using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FindMy.Domaim.Entity;

namespace FindMy.Domaim.Concrate
{
    public  class EFDbContext : DbContext
    {
        public DbSet<PersonLacation> PersonLacations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
