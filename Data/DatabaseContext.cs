using IntercityBusService.Models;
using Microsoft.EntityFrameworkCore;

namespace IntercityBusService.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Bus> Buses { get; set; }
        public DbSet<Ride> Rides { get; set; }
        public DbSet<Ticket> Tickets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region (Accounts)
            modelBuilder.Entity<User>().ToTable("User");
            #endregion

            #region (Locations)
            modelBuilder.Entity<Location>().ToTable("Location");
            modelBuilder.Entity<Route>().ToTable("Route");
            #endregion

            #region (Materials)
            modelBuilder.Entity<BusType>().ToTable("BusType");
            modelBuilder.Entity<Bus>().ToTable("Bus");
            #endregion

            #region (TicketReservation)
            modelBuilder.Entity<Ticket>().ToTable("Ticket");
            #endregion

            #region (Timetable)
            modelBuilder.Entity<Ride>().ToTable("Ride");
            modelBuilder.Entity<Schedule>().ToTable("Schedule");
            #endregion
        }
    }
}