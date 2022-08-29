using HungryPizza.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace HungryPizza.Persistence.EntityConfig;
public static class ItemFlavorsConfig
{
    public static void Config(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ItemFlavorsEntity>(entity =>
        {
            #region Key
            entity.ToTable("ItemFlavors");
            entity.HasKey(x => x.Id);
            entity
                .Property(e => e.Id)
                .HasColumnName("ItemFlavorsID")
                .IsRequired();
            #endregion Key

            #region FKs
            entity.HasOne(e => e.OrderItem)
            .WithMany(f => f.ItemFlavorsOrderList)
            .HasForeignKey(k => k.OrderItemID);

            entity.HasOne(e => e.PizzaFlavor)
            .WithMany(f => f.ItemFlavorsList)
            .HasForeignKey(k => k.PizzaFlavorID);
            #endregion FKs

        });
    }
}

