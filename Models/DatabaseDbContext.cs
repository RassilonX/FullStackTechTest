using Database.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database;

public class DatabaseDbContext : DbContext
{
    public DatabaseDbContext(DbContextOptions<DatabaseDbContext> options) : base(options)
    {
        
    }

    public DbSet<Person> People { get; set; }
    public DbSet<Address> Addresses { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Person>()
            .Property(p => p.FirstName)
            .HasColumnType("varchar(50)");

        modelBuilder.Entity<Person>()
            .Property(p => p.LastName)
            .HasColumnType("varchar(50)");

        modelBuilder.Entity<Address>()
            .Property(a => a.Line1)
            .HasColumnType("varchar(200)");

        modelBuilder.Entity<Address>()
            .Property(a => a.City)
            .HasColumnType("varchar(100)");

        modelBuilder.Entity<Address>()
            .Property(a => a.Postcode)
            .HasColumnType("varchar(8)");
    }
}
