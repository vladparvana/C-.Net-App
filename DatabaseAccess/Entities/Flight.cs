using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace DatabaseAccess.Entities
{
    /// <summary>
    /// Clasa care reprezintă un zbor în sistemul de gestionare a bazei de date.
    /// </summary>
    public class Flight
    {
        /// <summary>
        /// Identificator unic pentru zbor.
        /// </summary>
        [Key]
        public int ZborID { get; set; }

        /// <summary>
        /// Orașul de plecare al zborului.
        /// </summary>
        public string OrasPlecare { get; set; }

        /// <summary>
        /// Orașul destinație al zborului.
        /// </summary>
        public string OrasDestinatie { get; set; }

        /// <summary>
        /// Distanta zborului.
        /// </summary>
        public double Distanta { get; set; }

        /// <summary>
        /// Durata estimată a zborului.
        /// </summary>
        public double DurataEstimata { get; set; }

        /// <summary>
        /// Data și ora de plecare a zborului.
        /// </summary>
        public DateTime DataPlecare { get; set; }

        /// <summary>
        /// Numărul de locuri disponibile în zbor.
        /// </summary>
        public int LocuriDisponibile { get; set; }

        /// <summary>
        /// Prețul unui bilet pentru acest zbor.
        /// </summary>
        public decimal PretBilet { get; set; }

        /// <summary>
        /// Colectia de bilete asociate acestui zbor.
        /// </summary>
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
