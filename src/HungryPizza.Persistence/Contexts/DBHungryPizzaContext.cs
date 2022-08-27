using Microsoft.EntityFrameworkCore;
using HungryPizza.Domain.Entities;
using HungryPizza.Persistence.EntityConfig;

namespace HungryPizza.Persistence.Contexts;
public class DBHungryPizzaContext : DbContext
{
    public DBHungryPizzaContext()
    {

    }
    public DBHungryPizzaContext(DbContextOptions<DBHungryPizzaContext> options) 
        : base(options)
    {
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server = (localdb)\\mssqllocaldb; Database = dbHungryPizza; Trusted_Connection = True; MultipleActiveResultSets = true");

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        ClientConfig.Config(modelBuilder);
        PizzaFlavorConfig.Config(modelBuilder);
        PizzaFlavorsPriceConfig.Config(modelBuilder);
        OrderConfig.Config(modelBuilder);
        OrderItemConfig.Config(modelBuilder);
        ItemFlavorsConfig.Config(modelBuilder);

    }

    public DbSet<ClientEntity>? Client { get; set; }
    public DbSet<PizzaFlavorEntity>? PizzaFlavor { get; set; }
    public DbSet<PizzaFlavorsPriceEntity>? PizzaFlavorsPrice { get; set; }
    public DbSet<OrderEntity>? Order{ get; set; }
    public DbSet<OrderItemEntity>? OrderItem { get; set; }
    public DbSet<ItemFlavorsEntity>? ItemFlavors { get; set; }

}

