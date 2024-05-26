using DatabaseAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Handlers
{
    public class DurationHandler : FlightHandler
    {
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
