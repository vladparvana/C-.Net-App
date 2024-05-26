using DatabaseAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Interfaces
{
    public interface IFlightHandler
    {
        void Handle(Flight flight);
        IFlightHandler SetNext(IFlightHandler handler);
    }
}
