using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace test.Models.Data
{
    public class Context : DbContext
    {
        public Context() : base("test")
        {
            //Database.SetInitializer<Context>(null);
        }

        public DbSet<PoTransaction> PoTransactions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}