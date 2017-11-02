using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Test.Domain;

namespace Test.Data
{
    public class Context : DbContext
    {
        public Context() : base("test")
        {
            Database.SetInitializer<Context>(null);
        }

        public DbSet<PoInfo> PoInfo { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}