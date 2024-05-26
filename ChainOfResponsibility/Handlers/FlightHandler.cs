using ChainOfResponsibility.Interfaces;
using DatabaseAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Handlers
{
    public abstract class FlightHandler : IFlightHandler
    {
        private IFlightHandler _nextHandler;

        public IFlightHandler SetNext(IFlightHandler handler)
        {
            _nextHandler = handler;
            return handler;
        }

        public virtual void Handle(Flight flight)
        {
            if (_nextHandler != null)
            {
                _nextHandler.Handle(flight);
            }
        }
    }
}
