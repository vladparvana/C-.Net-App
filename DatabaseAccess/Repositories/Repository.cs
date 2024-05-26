using DatabaseAccess.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;


namespace DatabaseAccess.Repositories
{
    /// <summary>
    /// Implementarea generică a interfeței IRepository<T> utilizând Entity Framework.
    /// </summary>
    /// <typeparam name="T">Tipul entității pentru care este definit repository-ul.</typeparam>
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DbContext _context;
        private readonly DbSet<T> _dbSet;

        /// <summary>
        /// Constructorul clasei Repository care primește un obiect DbContext.
        /// </summary>
        /// <param name="context">Obiectul DbContext asociat repository-ului.</param>
        public Repository(DbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        /// <summary>
        /// Adaugă o entitate în repository.
        /// </summary>
        /// <param name="entity">Entitatea care trebuie adăugată.</param>
        public void Add(T entity)
        {
            _dbSet.Add(entity);
        }

        /// <summary>
        /// Actualizează o entitate în repository.
        /// </summary>
        /// <param name="entity">Entitatea care trebuie actualizată.</param>
        public void Update(T entity)
        {
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        /// <summary>
        /// Șterge o entitate din repository.
        /// </summary>
        /// <param name="entity">Entitatea care trebuie ștearsă.</param>
        public void Delete(T entity)
        {
            if (_context.Entry(entity).State == EntityState.Detached)
            {
                _dbSet.Attach(entity);
            }
            _dbSet.Remove(entity);
        }

        /// <summary>
        /// Obține o entitate din repository pe baza unui identificator unic.
        /// </summary>
        /// <param name="id">Identificatorul unic al entității.</param>
        /// <returns>Entitatea cu identificatorul specificat sau null dacă nu este găsită.</returns>
        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        /// <summary>
        /// Obține toate entitățile din repository.
        /// </summary>
        /// <returns>O colecție de entități.</returns>
        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }
    }
}
