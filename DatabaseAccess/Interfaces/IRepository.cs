using System;
using System.Collections.Generic;


namespace DatabaseAccess.Interfaces
{
    /// <summary>
    /// Interfața generică pentru un repository care definește operațiile de bază de acces la date.
    /// </summary>
    /// <typeparam name="T">Tipul entității pentru care este definit repository-ul.</typeparam>
    public interface IRepository<T> where T : class
    {
        /// <summary>
        /// Adaugă o entitate în repository.
        /// </summary>
        /// <param name="entity">Entitatea care trebuie adăugată.</param>
        void Add(T entity);

        /// <summary>
        /// Actualizează o entitate în repository.
        /// </summary>
        /// <param name="entity">Entitatea care trebuie actualizată.</param>
        void Update(T entity);

        /// <summary>
        /// Șterge o entitate din repository.
        /// </summary>
        /// <param name="entity">Entitatea care trebuie ștearsă.</param>
        void Delete(T entity);

        /// <summary>
        /// Obține o entitate din repository pe baza unui identificator unic.
        /// </summary>
        /// <param name="id">Identificatorul unic al entității.</param>
        /// <returns>Entitatea cu identificatorul specificat sau null dacă nu este găsită.</returns>
        T GetById(int id);

        /// <summary>
        /// Obține toate entitățile din repository.
        /// </summary>
        /// <returns>O colecție de entități.</returns>
        IEnumerable<T> GetAll();
    }
}
