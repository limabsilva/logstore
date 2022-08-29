using HungryPizza.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace HungryPizza.Persistence.EntityConfig;
public static class PizzaFlavorConfig
{
    public static void Config(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PizzaFlavorEntity>(entity =>
        {
            #region Key
            entity.ToTable("PizzaFlavor");
            entity.HasKey(x => x.Id);
            entity
                .Property(e => e.Id)
                .HasColumnName("PizzaFlavorID")
                .IsRequired();
            #endregion Key


            #region Columns
            entity.Property(e => e.Flavor).HasColumnName("Flavor").HasColumnType("nvarchar(200)");
            entity.Property(e => e.Ingredients).HasColumnName("Ingredients").HasColumnType("nvarchar(500)");
            #endregion Columns


        });
    }
}

