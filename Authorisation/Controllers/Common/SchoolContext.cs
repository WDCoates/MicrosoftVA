using System.Web.Mvc;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace Authorisation.Controllers
{ 
    public class SchoolContext : DbContext

    {
        public SchoolContext() : base("SchoolContext")
        {
        }

        //public DbSet<Department> Departments { get; set; }
        //public DbSet<MenuItem> MenuItems { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    Database.SetInitializer<SchoolContext>(null);

        //    modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        //    modelBuilder.Entity<Department>().MapToStoredProcedures();
        //    modelBuilder.Entity<MenuItem>().MapToStoredProcedures();
        //}
    }
}