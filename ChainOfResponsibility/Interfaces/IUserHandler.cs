using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseAccess.Entities;


namespace ChainOfResponsibility.Interfaces
{
    /// <summary>
    /// Interfata Handler-ului pentru obiectele de tip User din DatabaseAccess.Entities;
    /// </summary>
    public interface IUserHandler
    {
        /// <summary>
        /// Metoda de verificare a obiectului User din DatabaseAccess.Entities
        /// </summary>
        /// <param name="user">Obiectul de tip User </param>
        void Handle(User user);

        /// <summary>
        /// Metoda de setare a urmatorului Handler
        /// </summary>
        /// <param name="handler">Obiectul de tip Handler </param>
        /// /// <returns>Urmatorul handler</returns>
        IUserHandler SetNext(IUserHandler handler);
    }
}
