using Microsoft.EntityFrameworkCore;
 namespace spotify_client.Models;

 public class ItemsContext : DbContext
 {
    public ItemsContext( DbContextOptions<ItemsContext> options)
    : base(options)
    {

    }
    public DbSet<Items> Item { get; set;} = null!;
 }