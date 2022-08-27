using HungryPizza.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace HungryPizza.Persistence.EntityConfig;
public static class PizzaFlavorsPriceConfig
{
    public static void Config(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PizzaFlavorsPriceEntity>(entity =>
        {
            #region Key
            entity.ToTable("PizzaFlavorsPrice");
            entity.HasKey(x => x.Id);
            entity
                .Property(e => e.Id)
                .HasColumnName("PizzaFlavorsPriceID")
                .IsRequired();
            #endregion Key

            #region FKs
            entity.HasOne(e => e.PizzaFlavorEntity)
            .WithMany(f => f.PizzaFlavorsPrices)
            .HasForeignKey(k => k.PizzaFlavorEntityID);
            #endregion FKs

            #region Columns
            entity.Property(e => e.Price).HasColumnName("Price").HasColumnType("decimal(18,2)");
            entity.Property(e => e.Size).HasColumnName("Size").HasColumnType("nvarchar(20)");
            #endregion Columns


        });
    }
}
