using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Test.Domain;
using Test.Domain.Maps;
using Test.Domain.Models;

namespace Test.Data
{
    public class Context : DbContext
    {
        public Context() : base("test")
        {
            Database.SetInitializer<Context>(new NullDatabaseInitializer<Context>());
        }

        public DbSet<PoInfo> PoInfos { get; set; }
        public DbSet<LineItem> LineItems { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Configurations.Add(new PoInfoMap());
            modelBuilder.Configurations.Add(new LineItemMap());
        }
    }
}
