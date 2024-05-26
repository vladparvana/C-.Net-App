using ChainOfResponsibility.Handlers;
using ChainOfResponsibility.Interfaces;
using DatabaseAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Validators
{
    public class FlightValidator
    {
        private readonly IFlightHandler _handler;

        public FlightValidator()
        {
            _handler = new CityHandler();
            _handler.SetNext(new SeatsHandler())
                    .SetNext(new PriceHandler())
                    .SetNext(new DurationHandler())
                    .SetNext(new DistanceHandler())
                    .SetNext(new DateHandler());
        }

        public void Validate(Flight flight)
        {
            _handler.Handle(flight);
        }
    }
}
