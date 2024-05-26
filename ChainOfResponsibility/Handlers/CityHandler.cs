using DatabaseAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ChainOfResponsibility.Handlers
{
    /// <summary>
    /// Clasa folosita pentru verificare a oraselor
    /// </summary>
    public class CityHandler :FlightHandler
    {
        /// <summary>
        /// Metoda de verificare a oraselor
        /// </summary>
        /// <param name="Flight">Obiectul de tip Flight </param>
        public override void Handle(Flight flight)
        {
            if (string.IsNullOrWhiteSpace(flight.OrasPlecare) || string.IsNullOrWhiteSpace(flight.OrasDestinatie))
            {
                throw new ArgumentException("Numele nu poate fi null sau gol.");
            }
            base.Handle(flight);
        }
    }
}
