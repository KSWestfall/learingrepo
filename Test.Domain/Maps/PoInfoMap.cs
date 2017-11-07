using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Test.Domain.Models;

namespace Test.Domain.Maps
{
    public class PoInfoMap : EntityTypeConfiguration<PoInfo>
    {
        public PoInfoMap()
        {
            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.ToTable("PoInfo");
            this.Property(x => x.SenderId).HasColumnName("SenderId").IsRequired().HasColumnType("int");
            this.Property(x => x.UnitType).HasColumnName("UnitType").IsRequired().HasColumnType("int");
            this.Property(x => x.Po).HasColumnName("Po").IsRequired().HasColumnType("nvarchar(max)");
            this.Property(x => x.Notes).HasColumnName("Notes").HasColumnType("nvarchar(max)");
            this.Property(x => x.Sidemark).HasColumnName("Sidemark").IsRequired().HasColumnType("nvarchar(max)");
            this.Property(x => x.StName).HasColumnName("StName").IsRequired().HasColumnType("nvarchar(max)");
            this.Property(x => x.StAddress1).HasColumnName("StAddress1").IsRequired().HasColumnType("nvarchar(max)");
            this.Property(x => x.StAddress2).HasColumnName("StAddress2").HasColumnType("nvarchar(max)");
            this.Property(x => x.StCity).HasColumnName("StCity").IsRequired().HasColumnType("nvarchar(max)");
            this.Property(x => x.StState).HasColumnName("StState").IsRequired().HasColumnType("nvarchar(max)");
            this.Property(x => x.StZip).HasColumnName("StZip").IsRequired().HasColumnType("nvarchar(max)");
            this.Property(x => x.StPhone).HasColumnName("StPhone").IsRequired().HasColumnType("nvarchar(max)");
        }
    }
}
