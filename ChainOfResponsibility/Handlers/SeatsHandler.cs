using DatabaseAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Handlers
{
    public class SeatsHandler : FlightHandler
    {
        public override void Handle(Flight flight)
        {
            if (flight.LocuriDisponibile < 0)
            {
                throw new ArgumentException("Numarul locurilor disponibile trebuie să fie de tip intreg si mai mare ca 0.");
            }
            base.Handle(flight);
        }
    }
}
