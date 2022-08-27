using HungryPizza.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace HungryPizza.Persistence.EntityConfig;
public static class OrderConfig
{
    public static void Config(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<OrderEntity>(entity =>
        {
            #region Key
            entity.ToTable("Order");
            entity.HasKey(x => x.Id);
            entity
                .Property(e => e.Id)
                .HasColumnName("OrderID")
                .IsRequired();
            #endregion Key

            #region FKs
            entity.HasOne(e => e.Client)
            .WithMany(f => f.Orders)
            .HasForeignKey(k => k.ClientID);
            #endregion FKs

            #region Columns
            entity.Property(e => e.Description).HasColumnName("Description").HasColumnType("nvarchar(500)");
            entity.Property(e => e.DeliveryAddress).HasColumnName("DeliveryAddress").HasColumnType("nvarchar(500)").IsRequired();
            entity.Property(e => e.PriceTotal).HasColumnName("PriceTotal").HasColumnType("decimal(18,2)");
            #endregion Columns

        });
    }
}

