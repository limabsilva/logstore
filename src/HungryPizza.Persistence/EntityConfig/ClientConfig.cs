using HungryPizza.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace HungryPizza.Persistence.EntityConfig;
public static class ClientConfig
{
    public static void Config(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ClientEntity>(entity =>
        {
            #region Key
            entity.ToTable("Client");
            entity.HasKey(x => x.Id);
            entity
                .Property(e => e.Id)
                .HasColumnName("ClientID")
                .IsRequired();
            #endregion Key


            #region Columns
            entity.HasIndex(e => e.Telephone).IsUnique();          
            entity
                .Property(e => e.Telephone)
                .HasColumnName("Telephone")
                .HasColumnType("nvarchar(11)")                
                .IsRequired();
            entity.Property(e => e.Name).HasColumnName("Name").HasColumnType("nvarchar(200)").IsRequired();
            entity.Property(e => e.StreetName).HasColumnName("StreetName").HasColumnType("nvarchar(200)").IsRequired();
            entity.Property(e => e.Number).HasColumnName("Number").HasColumnType("int").IsRequired();
            entity.Property(e => e.Complement).HasColumnName("Complement").HasColumnType("nvarchar(100)");
            entity.Property(e => e.Neighborhood).HasColumnName("Neighborhood").HasColumnType("nvarchar(100)").IsRequired();
            entity.Property(e => e.City).HasColumnName("City").HasColumnType("nvarchar(100)").IsRequired();
            entity.Property(e => e.State).HasColumnName("State").HasColumnType("nvarchar(100)").IsRequired();
            entity.Property(e => e.ZipCode).HasColumnName("ZipCode").HasColumnType("nvarchar(20)").IsRequired();
            #endregion Columns


        });
    }
}
