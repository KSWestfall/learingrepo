using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Test.Domain.Models;

namespace Test.Domain.Maps
{
    public class LineItemMap : EntityTypeConfiguration<LineItem>
    {
        public LineItemMap()
        {
            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.HasRequired(x => x.PoInfo).WithMany(x => x.LineItems);
            this.ToTable("LineItem");
            this.Property(x => x.Sku).HasColumnName("Sku").IsRequired().HasColumnType("nvarchar(max)");
            this.Property(x => x.Model).HasColumnName("Model").IsRequired().HasColumnType("nvarchar(max)");
            this.Property(x => x.Quantity).HasColumnName("Quantity").IsRequired().HasColumnType("int");
            this.Property(x => x.Color).HasColumnName("Color").IsRequired().HasColumnType("nvarchar(max)");
            this.Property(x => x.Width).HasColumnName("Width").IsRequired().HasColumnType("int");
            this.Property(x => x.Height).HasColumnName("Height").IsRequired().HasColumnType("int");
            this.Property(x => x.Mount).HasColumnName("Mount").IsRequired().HasColumnType("nvarchar(max)");
            this.Property(x => x.ControlType).HasColumnName("ControlType").IsRequired().HasColumnType("nvarchar(max)");
            this.Property(x => x.Sidemark).HasColumnName("Sidemark").IsRequired().HasColumnType("nvarchar(max)");
            this.Property(x => x.SpecialInstructions).HasColumnName("SpecialInstructions").HasColumnType("nvarchar(max)");
            this.Property(x => x.HandSample).HasColumnName("HandSample").IsRequired().HasColumnType("nvarchar(max)");
        }
    }
}
