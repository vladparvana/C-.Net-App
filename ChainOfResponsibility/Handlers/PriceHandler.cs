using DatabaseAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ChainOfResponsibility.Handlers
{
    /// <summary>
    /// Clasa folosita pentru verificare a pretului
    /// </summary>
    public class PriceHandler : FlightHandler
    {
        /// <summary>
        /// Metoda de verificare a pretului
        /// </summary>
        /// <param name="flight">Obiectul de tip Flight </param>
        public override void Handle(Flight flight)
        {
            if ( flight.PretBilet < 0)
            {
                throw new ArgumentException("Pretul biletului trebuie să fie mai mare ca 0.");
            }
            base.Handle(flight);
        }
    }
}
