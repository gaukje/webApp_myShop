using System;
using Microsoft.EntityFrameworkCore;

namespace MyShop.Models;

public class ItemDbContext : DbContext
{
	public ItemDbContext(DbContextOptions<ItemDbContext> options) : base(options)
	{
        Database.EnsureCreated();
	}

	public DbSet<Item> Items { get; set; }
	public DbSet<Customer> Customers { get; set; }
	public DbSet<Order>? Orders { get; set;}
	public DbSet<OrderItem> OrderItems { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseLazyLoadingProxies();
    }
}


/*By calling UseLazyLoadingProxies() in the OnConfiguring method, EF Core will generate
 * proxies for your entity classes, allowing lazy loading of related entities when accessed.
 * 
 * With lazy loading enabled, when you access a navigation property like OrderItems of the Order class,
 * EF Core will automatically load the related OrderItem entities from the database on-demand, without
 * explicitly loading the entire tree of dependent objects connected by the navigation properties.
 * 
 * Consider using eager loading or explicit loading in performance-critical scenarios.
 */
