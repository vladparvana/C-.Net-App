using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseAccess.Entities;
using ChainOfResponsibility.Interfaces;


namespace ChainOfResponsibility.Handlers
{
    /// <summary>
    /// Clasa abstracta pentru obiectele de tip User din DatabaseAccess.Entities ce extinde IUserHandler
    /// </summary>
    public abstract class UserHandler : IUserHandler
    {
        /// <summary>
        /// Obiect ce referentiaza urmatorul Handler ce trebuie tratat
        /// </summary>
        private IUserHandler _nextHandler;

        /// <summary>
        /// Metoda de setare a urmatorului Handler
        /// </summary>
        /// <param name="handler">Obiectul de tip Handler </param>
        /// <returns>Urmatorul handler</returns>
        public IUserHandler SetNext(IUserHandler handler)
        {
            _nextHandler = handler;
            return handler;
        }

        /// <summary>
        /// Metoda de verificare a obiectului User din DatabaseAccess.Entities
        /// </summary>
        /// <param name="user">Obiectul de tip User </param>
        public virtual void Handle(User user)
        {
            if (_nextHandler != null)
            {
                _nextHandler.Handle(user);
            }
        }
    }

}
