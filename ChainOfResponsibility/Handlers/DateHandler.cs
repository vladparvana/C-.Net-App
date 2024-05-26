using DatabaseAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ChainOfResponsibility.Handlers
{
    /// <summary>
    /// Clasa folosita pentru verificare a datei de plecare
    /// </summary>
    public class DateHandler : FlightHandler
    {
        /// <summary>
        /// Metoda de verificare a datei de plecare
        /// </summary>
        /// <param name="flight">Obiectul de tip Flight </param>
        public override void Handle(Flight flight)
        {
            if (flight.DataPlecare <= DateTime.Now)
            {
                throw new ArgumentException("Data zborului trebuie să fie în viitor.");
            }
            base.Handle(flight);
        }
    }
}
