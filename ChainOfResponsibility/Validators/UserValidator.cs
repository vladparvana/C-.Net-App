using DatabaseAccess.Entities;
using ChainOfResponsibility.Handlers;
using ChainOfResponsibility.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ChainOfResponsibility.Validators
{
    /// <summary>
    /// Validator pentru utilizatori, care utilizează un lanț de responsabilitate pentru validare.
    /// </summary>
    public class UserValidator
    {
        private readonly IUserHandler _handler;

        /// <summary>
        /// Constructorul clasei UserValidator.
        /// Inițializează lanțul de responsabilitate cu diferitele manipulatoare de validare.
        /// </summary>
        public UserValidator()
        {
            // Inițializează lanțul de responsabilitate cu primul manipulator care va fi utilizat.
            _handler = new NameHandler();
            _handler.SetNext(new EmailHandler())
                    .SetNext(new PasswordHandler())
                    .SetNext(new AgeHandler());

        }
        /// <summary>
        /// Metoda pentru validarea unui utilizator folosind lanțul de responsabilitate.
        /// </summary>
        /// <param name="user">Utilizatorul care trebuie validat.</param>
        public void Validate(User user)
        {
            // Apelarea metodei Handle() a primului manipulator din lanț pentru a începe validarea.
            _handler.Handle(user);
        }
    }
}
