using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseAccess.Entities;
using ChainOfResponsibility.Interfaces;

namespace ChainOfResponsibility.Handlers
{
    public abstract class UserHandler : IUserHandler
    {
        private IUserHandler _nextHandler;

        public IUserHandler SetNext(IUserHandler handler)
        {
            _nextHandler = handler;
            return handler;
        }

        public virtual void Handle(User user)
        {
            if (_nextHandler != null)
            {
                _nextHandler.Handle(user);
            }
        }
    }

}
