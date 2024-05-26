using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace DatabaseAccess.Entities
{
    /// <summary>
    /// Clasa care reprezintă un utilizator în sistemul de gestionare a bazei de date.
    /// </summary>
    public class User
    {
        /// <summary>
        /// Identificator unic pentru utilizator.
        /// </summary>
        [Key]
        public int UserID { get; set; }

        /// <summary>
        /// Numele utilizatorului.
        /// </summary>
        public string Nume { get; set; }

        /// <summary>
        /// Prenumele utilizatorului.
        /// </summary>
        public string Prenume { get; set; }

        /// <summary>
        /// Data de naștere a utilizatorului.
        /// </summary>
        public DateTime DataNastere { get; set; }

        /// <summary>
        /// Adresa de email a utilizatorului.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Parola utilizatorului (criptată).
        /// </summary>
        public string Parola { get; set; }

        /// <summary>
        /// Indicator pentru statutul de administrator al utilizatorului.
        /// </summary>
        public string Admin { get; set; }

        /// <summary>
        /// Colectia de bilete asociate acestui utilizator.
        /// </summary>
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
