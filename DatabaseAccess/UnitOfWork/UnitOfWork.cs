using DatabaseAccess.Entities;
using DatabaseAccess.Interfaces;
using DatabaseAccess.Repositories;
using System;
using System.Data.Entity;

namespace DatabaseAccess.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext _context;
        public IRepository<User> Users { get; private set; }
        public IRepository<Flight> Flights { get; private set; }
        public IRepository<Ticket> Tickets { get; private set; }
        // Initialize other repositories here

        public UnitOfWork(DbContext context)
        {
            _context = context;
            Users = new Repository<User>(_context);
            Flights = new Repository<Flight>(_context);
            Tickets = new Repository<Ticket>(_context);
            // Initialize other repositories here
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
