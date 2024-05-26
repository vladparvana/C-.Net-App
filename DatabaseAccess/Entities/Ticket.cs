using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.Entities
{
    public class Ticket
    {
        [Key, Column(Order = 0)]
        public int BiletID { get; set; }

        [Key, Column(Order = 1)]
        [ForeignKey("Flight")] // Cheie străină către entitatea Flight
        public int ZborID { get; set; }

        [ForeignKey("User")] // Cheie străină către entitatea User
        public int UserID { get; set; }

        // Proprietate pentru legătura către entitatea User
        public virtual User User { get; set; }

        // Proprietate pentru legătura către entitatea Flight
        public virtual Flight Flight { get; set; }

        public int Loc { get; set; }
        public DateTime DataCumparare { get; set; }
        public decimal PretBilet { get; set; }
        public string Stare { get; set; }
    }
}
