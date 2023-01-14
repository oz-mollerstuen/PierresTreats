using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace PierresSweets.Models{

  public class PierresSweetsContext : IDesignTimeDbContextFactory<PierresSweetsContext>
  {
    public DbSet<Flavor> Flavors { get; set; }
    public DbSet<Treat> Treats { get; set; }
    public DbSet<FlavorTreat> FlavorTreat { get; set; }

    public PierresSweetsContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
     {
      optionsBuilder.UseLazyLoadingProxies();
    }

  }
}