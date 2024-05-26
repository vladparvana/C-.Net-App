using DatabaseAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.SQLite;

namespace DatabaseAccess.Database
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(string databasePath)
            : base(new SQLiteConnection($"Data Source={databasePath}"),true)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Ticket> Tickets { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Ticket>()
                .HasKey(t => new { t.BiletID, t.ZborID });

            modelBuilder.Entity<Ticket>()
                .HasRequired<User>(t => t.User)
                .WithMany(u => u.Tickets)
                .HasForeignKey(t => t.UserID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Ticket>()
                .HasRequired<Flight>(t => t.Flight)
                .WithMany(f => f.Tickets)
                .HasForeignKey(t => t.ZborID)
                .WillCascadeOnDelete(false);


        }
    }
}