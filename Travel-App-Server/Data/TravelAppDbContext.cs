using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Travel_App_Server.Models;

namespace Travel_App_Server.Data
{
    public class TravelAppDbContext : IdentityDbContext<User>
    {
        public TravelAppDbContext(DbContextOptions<TravelAppDbContext> options)
        : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=Travel-App;Integrated Security=True;Pooling=False;Encrypt=False;TrustServerCertificate=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configura precisione e scala per i valori decimal
            modelBuilder.Entity<Destination>()
                .Property(d => d.Latitude)
                .HasColumnType("decimal(9,6)");

            modelBuilder.Entity<Destination>()
                .Property(d => d.Longitude)
                .HasColumnType("decimal(9,6)");

            modelBuilder.Entity<Place>()
                .Property(p => p.Latitude)
                .HasColumnType("decimal(9,6)");

            modelBuilder.Entity<Place>()
                .Property(p => p.Longitude)
                .HasColumnType("decimal(9,6)");

            modelBuilder.Entity<Expense>()
                .Property(e => e.Cost)
                .HasColumnType("decimal(18,2)");
        }

        public DbSet<Trip> Trips { get; set; }
        public DbSet<Day> Days { get; set; }
        public DbSet<Step> Steps { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Place> Places { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<User> Users { get; set; }
    }

}
