using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseAccess.Entities;

namespace ChainOfResponsibility.Interfaces
{
    public interface IUserHandler
    {
        void Handle(User user);
        IUserHandler SetNext(IUserHandler handler);
    }
}
