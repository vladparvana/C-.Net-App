using DatabaseAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Handlers
{
    public class AgeHandler : UserHandler
    {
        public override void Handle(User user)
        {
            if ((DateTime.Now.Year - user.DataNastere.Year) < 18)
            {
                throw new ArgumentException("Utilizatorul trebuie să aibă cel puțin 18 ani.");
            }
            base.Handle(user);
        }
    }

}
