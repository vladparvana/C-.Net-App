using DatabaseAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Handlers
{
    public class CityHandler :FlightHandler
    {
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
