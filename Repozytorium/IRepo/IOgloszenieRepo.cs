using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repozytorium.Models;

namespace Repozytorium.IRepo
{
    public interface IOgloszenieRepo
    {
        IQueryable<Ogloszenie> PobierzOgloszenia();
    }
}
