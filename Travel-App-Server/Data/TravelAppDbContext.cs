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
