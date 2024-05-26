using DatabaseAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ChainOfResponsibility.Handlers
{
    /// <summary>
    /// Clasa folosita pentru verificare a distantei
    /// </summary>
    public class DistanceHandler :FlightHandler
    {
        /// <summary>
        /// Metoda de verificare a distantei
        /// </summary>
        /// <param name="flight">Obiectul de tip Flight </param>
        public override void Handle(Flight flight)
        {
            if ( flight.Distanta < 0)
            {
                throw new ArgumentException("Durata estimata trebuie să fie mai mare ca 0.");
            }
            base.Handle(flight);
        }
    }
}
