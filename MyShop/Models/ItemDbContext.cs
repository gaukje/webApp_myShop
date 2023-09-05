using System;
using Microsoft.EntityFrameworkCore;

namespace MyShop.Models;

public class ItemDbContext : DbContext
{
    public ItemDbContext(DbContextOptions<ItemDbContext> options) : base(options) //This line defines a class named 'ItemDbContext' that inherits from 'DbContext', which is a base class provided by Entity Framwork COre for creating a database context. A database context represents a session with the database, allowing you to query and manipulate data.
    { //This is a constructor for the 'ItemDbContext' class. It takes an instance of 'DbContextOptions-ItemDbContext- as a parameter. This constructor is typically used to configure the database connection and options.
        Database.EnsureCreated();       //Creates empty database in case it doesn't exist
    }

    public DbSet<Item> Items { get; set; }  
}
