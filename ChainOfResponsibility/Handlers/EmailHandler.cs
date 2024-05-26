using DatabaseAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ChainOfResponsibility.Handlers
{
    /// <summary>
    /// Clasa folosita pentru verificare a email-ului
    /// </summary>
    public class EmailHandler : UserHandler
    {
        /// <summary>
        /// Metoda de verificare a email-ului User-ului
        /// </summary>
        /// <param name="user">Obiectul de tip User </param>
        public override void Handle(User user)
        {
            if (!IsValidEmail(user.Email))
            {
                throw new ArgumentException("Adresa de email este invalidă.");
            }
            base.Handle(user);
        }

        /// <summary>
        /// Metoda care verifica daca email-ul are format valid
        /// </summary>
        /// <param name="user">Obiectul de tip User </param>
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
