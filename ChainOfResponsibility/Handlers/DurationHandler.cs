using DatabaseAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ChainOfResponsibility.Handlers
{
    /// <summary>
    /// Clasa folosita pentru verificare a duratei
    /// </summary>
    public class DurationHandler : FlightHandler
    {
        /// <summary>
        /// Metoda de verificare a duratei
        /// </summary>
        /// <param name="flight">Obiectul de tip Flight </param>
        public override void Handle(Flight flight)
        {
            if (flight.DurataEstimata <0)
            {
                throw new ArgumentException("Durata estimata trebuie sa fie mai mare ca 0.");
            }
            base.Handle(flight);
        }
    }
}
