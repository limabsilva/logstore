using HungryPizza.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace HungryPizza.Persistence.EntityConfig;
public static class OrderItemConfig
{
    public static void Config(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<OrderItemEntity>(entity =>
        {
            #region Key
            entity.ToTable("OrderItem");
            entity.HasKey(x => x.Id);
            entity
                .Property(e => e.Id)
                .HasColumnName("OrderItemID")
                .IsRequired();
            #endregion Key

            #region FKs
            entity.HasOne(e => e.Order)
            .WithMany(f => f.OrderItems)
            .HasForeignKey(k => k.OrderID);
            #endregion FKs

            #region Columns
            entity.Property(e => e.Comments).HasColumnName("Comments").HasColumnType("nvarchar(500)");
            entity.Property(e => e.PriceItem).HasColumnName("PriceItem").HasColumnType("decimal(18,2)");
            #endregion Columns

        });
    }
}

