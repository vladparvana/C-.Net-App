using DatabaseAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChainOfResponsibility.Handlers;
using ChainOfResponsibility.Interfaces;


namespace ChainOfResponsibility.Handlers
{
    /// <summary>
    /// Clasa folosita pentru verificare a numelui
    /// </summary>
    public class NameHandler : UserHandler
    {
        /// <summary>
        /// Metoda de verificare a numelui
        /// </summary>
        /// <param name="user">Obiectul de tip User </param>
        public override void Handle(User user)
        {
            if (string.IsNullOrWhiteSpace(user.Nume) || string.IsNullOrWhiteSpace(user.Prenume))
            {
                throw new ArgumentException("Numele nu poate fi null sau gol.");
            }
            base.Handle(user);
        }
    }



}
