using DatabaseAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Handlers
{
    public class EmailHandler : UserHandler
    {
        public override void Handle(User user)
        {
            if (!IsValidEmail(user.Email))
            {
                throw new ArgumentException("Adresa de email este invalidă.");
            }
            base.Handle(user);
        }

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
