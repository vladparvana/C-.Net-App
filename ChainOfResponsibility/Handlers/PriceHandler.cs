using DatabaseAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Handlers
{
    public class PriceHandler : FlightHandler
    {
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
