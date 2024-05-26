using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.Entities
{
    public class Flight
    {
        [Key]
        public int ZborID { get; set; }
        public string OrasPlecare { get; set; }
        public string OrasDestinatie { get; set; }
        public double Distanta { get; set; }
        public double DurataEstimata { get; set; }
        public DateTime DataPlecare { get; set; }
        public int LocuriDisponibile { get; set; }
        public decimal PretBilet { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
