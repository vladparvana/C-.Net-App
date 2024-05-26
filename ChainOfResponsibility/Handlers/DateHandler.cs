using DatabaseAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Handlers
{
    public class DateHandler : FlightHandler
    {
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
