using DatabaseAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ChainOfResponsibility.Handlers
{
    /// <summary>
    /// Clasa folosita pentru verificare a parolei
    /// </summary>
    public class PasswordHandler : UserHandler
    {
        /// <summary>
        /// Metoda de verificare a parolei
        /// </summary>
        /// <param name="user">Obiectul de tip User </param>
        public override void Handle(User user)
        {
            if (string.IsNullOrWhiteSpace(user.Parola))
            {
                throw new ArgumentException("Parola nu poate fi null sau gol.");
            }
            base.Handle(user);
        }
    }
}
