using DatabaseAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChainOfResponsibility.Handlers;
using ChainOfResponsibility.Interfaces;

namespace ChainOfResponsibility.Validators
{
    public class UserValidator
    {
        private readonly IUserHandler _handler;

        public UserValidator()
        {
            _handler = new NameHandler();
            _handler.SetNext(new EmailHandler())
                    .SetNext(new PasswordHandler())
                    .SetNext(new AgeHandler());
        }

        public void Validate(User user)
        {
            _handler.Handle(user);
        }
    }
}
