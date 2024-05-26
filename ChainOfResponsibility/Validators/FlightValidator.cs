using ChainOfResponsibility.Handlers;
using ChainOfResponsibility.Interfaces;
using DatabaseAccess.Entities;
using System;


namespace ChainOfResponsibility.Validators
{
    /// <summary>
    /// Validatorul pentru zboruri, care utilizează un lanț de responsabilitate pentru validare.
    /// </summary>
    public class FlightValidator
    {
        private readonly IFlightHandler _handler;

        /// <summary>
        /// Constructorul clasei FlightValidator.
        /// Inițializează lanțul de responsabilitate cu diferitele manipulatoare de validare.
        /// </summary>
        public FlightValidator()
        {
            // Inițializează lanțul de responsabilitate cu primul manipulator care va fi utilizat.
            _handler = new CityHandler();
            _handler.SetNext(new SeatsHandler())
                    .SetNext(new PriceHandler())
                    .SetNext(new DurationHandler())
                    .SetNext(new DistanceHandler())
                    .SetNext(new DateHandler());
        }

        /// <summary>
        /// Metoda pentru validarea unui zbor folosind lanțul de responsabilitate.
        /// </summary>
        /// <param name="flight">Zborul care trebuie validat.</param>
        public void Validate(Flight flight)
        {
            // Apelarea metodei Handle() a primului manipulator din lanț pentru a începe validarea.
            _handler.Handle(flight);
        }
    }
}
