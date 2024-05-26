using DatabaseAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Handlers
{
    public class PasswordHandler : UserHandler
    {
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
