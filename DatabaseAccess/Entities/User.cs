using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.Entities
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public DateTime DataNastere { get; set; }
        public string Email { get; set; }
        public string Parola { get; set; }
        public string Admin { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
