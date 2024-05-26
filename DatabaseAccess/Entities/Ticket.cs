using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DatabaseAccess.Entities
{
    /// <summary>
    /// Clasa care reprezintă un bilet în sistemul de gestionare a bazei de date.
    /// </summary>
    public class Ticket
    {
        /// <summary>
        /// Identificator unic pentru bilet.
        /// </summary>
        [Key, Column(Order = 0)]
        public int BiletID { get; set; }

        /// <summary>
        /// Identificatorul zborului asociat acestui bilet (cheie străină către entitatea Flight).
        /// </summary>
        [Key, Column(Order = 1)]
        [ForeignKey("Flight")]
        public int ZborID { get; set; }

        /// <summary>
        /// Identificatorul utilizatorului care a achiziționat acest bilet (cheie străină către entitatea User).
        /// </summary>
        [ForeignKey("User")]
        public int UserID { get; set; }

        /// <summary>
        /// Proprietate pentru legătura către entitatea User asociată acestui bilet.
        /// </summary>
        public virtual User User { get; set; }

        /// <summary>
        /// Proprietate pentru legătura către entitatea Flight asociată acestui bilet.
        /// </summary>
        public virtual Flight Flight { get; set; }

        /// <summary>
        /// Numărul locului pe care este rezervat biletul.
        /// </summary>
        public int Loc { get; set; }

        /// <summary>
        /// Data și ora la care a fost cumpărat biletul.
        /// </summary>
        public DateTime DataCumparare { get; set; }

        /// <summary>
        /// Prețul biletului.
        /// </summary>
        public decimal PretBilet { get; set; }

        /// <summary>
        /// Starea biletului (de exemplu, "rezervat", "anulat", etc.).
        /// </summary>
        public string Stare { get; set; }
    }
}
