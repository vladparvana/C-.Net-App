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
    public class NameHandler : UserHandler
    {
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
