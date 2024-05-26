using DatabaseAccess.Entities;
using System;


namespace DatabaseAccess.Interfaces
{
    /// <summary>
    /// Interfața pentru o unitate de lucru care gestionează mai multe repository-uri.
    /// </summary>
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        /// Repository-ul pentru entitățile de tipul User.
        /// </summary>
        IRepository<User> Users { get; }

        /// <summary>
        /// Repository-ul pentru entitățile de tipul Flight.
        /// </summary>
        IRepository<Flight> Flights { get; }

        /// <summary>
        /// Repository-ul pentru entitățile de tipul Ticket.
        /// </summary>
        IRepository<Ticket> Tickets { get; }

        // Poți adăuga și alte repository-uri aici pentru alte entități din sistem

        /// <summary>
        /// Finalizează și aplică toate modificările efectuate în cadrul unității de lucru.
        /// </summary>
        /// <returns>Numărul de modificări salvate în baza de date.</returns>
        int Complete();
    }
}
