using ChainOfResponsibility.Interfaces;
using DatabaseAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ChainOfResponsibility.Handlers
{
    /// <summary>
    /// Clasa abstracta pentru obiectele de tip Flight din DatabaseAccess.Entities ce extinde IFlightHandler
    /// </summary>
    public abstract class FlightHandler : IFlightHandler
    {
        /// <summary>
        /// Obiect ce referentiaza urmatorul Handler ce trebuie tratat
        /// </summary>
        private IFlightHandler _nextHandler;

        /// <summary>
        /// Metoda de setare a urmatorului Handler
        /// </summary>
        /// <param name="handler">Obiectul de tip Handler </param>
        /// <returns>Urmatorul handler</returns>
        public IFlightHandler SetNext(IFlightHandler handler)
        {
            _nextHandler = handler;
            return handler;
        }

        /// <summary>
        /// Metoda de verificare a obiectului Flight din DatabaseAccess.Entities
        /// </summary>
        /// <param name="flight">Obiectul de tip Flight </param>
        public virtual void Handle(Flight flight)
        {
            if (_nextHandler != null)
            {
                _nextHandler.Handle(flight);
            }
        }
    }
}
