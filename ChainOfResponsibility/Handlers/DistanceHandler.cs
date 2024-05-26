using DatabaseAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Handlers
{
    public class DistanceHandler :FlightHandler
    {
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
