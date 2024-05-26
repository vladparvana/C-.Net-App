using DatabaseAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Interfaces
{
    /// <summary>
    /// Interfata Handler-ului pentru obiectele de tip Flight din DatabaseAccess.Entities;
    /// </summary>
    public interface IFlightHandler
    {
        /// <summary>
        /// Metoda de verificare a obiectului Flight din DatabaseAccess.Entities
        /// </summary>
        /// <param name="flight">Obiectul de tip Flight </param>
        void Handle(Flight flight);

        /// <summary>
        /// Metoda de setare a urmatorului Handler
        /// </summary>
        /// <param name="handler">Obiectul de tip Handler </param>
        /// <returns>Urmatorul handler</returns>
        IFlightHandler SetNext(IFlightHandler handler);
    }
}
