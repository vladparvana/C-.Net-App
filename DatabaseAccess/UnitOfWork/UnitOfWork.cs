using DatabaseAccess.Entities;
using DatabaseAccess.Interfaces;
using DatabaseAccess.Repositories;
using System;
using System.Data.Entity;


namespace DatabaseAccess.UnitOfWork
{
    /// <summary>
    /// Implementarea unei unități de lucru (UnitOfWork) pentru gestionarea mai multor repository-uri.
    /// </summary>
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext _context;

        /// <summary>
        /// Repository-ul pentru entitățile de tipul User.
        /// </summary>
        public IRepository<User> Users { get; private set; }

        /// <summary>
        /// Repository-ul pentru entitățile de tipul Flight.
        /// </summary>
        public IRepository<Flight> Flights { get; private set; }

        /// <summary>
        /// Repository-ul pentru entitățile de tipul Ticket.
        /// </summary>
        public IRepository<Ticket> Tickets { get; private set; }

        // Poți adăuga și alte repository-uri aici pentru alte entități din sistem

        /// <summary>
        /// Constructorul clasei UnitOfWork care primește un obiect DbContext și inițializează repository-urile asociate.
        /// </summary>
        /// <param name="context">Obiectul DbContext asociat unității de lucru.</param>
        public UnitOfWork(DbContext context)
        {
            _context = context;
            Users = new Repository<User>(_context);
            Flights = new Repository<Flight>(_context);
            Tickets = new Repository<Ticket>(_context);
        }

        /// <summary>
        /// Finalizează și aplică toate modificările efectuate în cadrul unității de lucru.
        /// </summary>
        /// <returns>Numărul de modificări salvate în baza de date.</returns>
        public int Complete()
        {
            return _context.SaveChanges();
        }

        /// <summary>
        /// Eliberează resursele utilizate de unitatea de lucru.
        /// </summary>
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
