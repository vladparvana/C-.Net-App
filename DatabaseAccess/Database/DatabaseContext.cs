using DatabaseAccess.Entities;
using System.Data.Entity;
using System.Data.SQLite;

namespace DatabaseAccess.Database
{
    /// <summary>
    /// Clasa care reprezintă contextul bazei de date utilizând Entity Framework.
    /// </summary>
    public class DatabaseContext : DbContext
    {
        /// <summary>
        /// Constructorul clasei DatabaseContext care primește calea către fișierul de bază de date SQLite.
        /// </summary>
        /// <param name="databasePath">Calea către fișierul de bază de date SQLite.</param>
        public DatabaseContext(string databasePath)
            : base(new SQLiteConnection($"Data Source={databasePath}"), true)
        {
            // Configurarea conexiunii SQLite
        }

        /// <summary>
        /// Setul de entități pentru utilizatorii din baza de date.
        /// </summary>
        public DbSet<User> Users { get; set; }

        /// <summary>
        /// Setul de entități pentru zborurile din baza de date.
        /// </summary>
        public DbSet<Flight> Flights { get; set; }

        /// <summary>
        /// Setul de entități pentru biletele din baza de date.
        /// </summary>
        public DbSet<Ticket> Tickets { get; set; }

        /// <summary>
        /// Configurarea modelului de date utilizând Fluent API.
        /// </summary>
        /// <param name="modelBuilder">Obiectul ModelBuilder folosit pentru configurare.</param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configurarea cheilor primare compuse pentru entitatea Ticket
            modelBuilder.Entity<Ticket>()
                .HasKey(t => new { t.BiletID, t.ZborID });

            // Configurarea relației dintre entitatea Ticket și entitatea User
            modelBuilder.Entity<Ticket>()
                .HasRequired<User>(t => t.User)
                .WithMany(u => u.Tickets)
                .HasForeignKey(t => t.UserID)
                .WillCascadeOnDelete(false);

            // Configurarea relației dintre entitatea Ticket și entitatea Flight
            modelBuilder.Entity<Ticket>()
                .HasRequired<Flight>(t => t.Flight)
                .WithMany(f => f.Tickets)
                .HasForeignKey(t => t.ZborID)
                .WillCascadeOnDelete(false);
        }
    }
}
