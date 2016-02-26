using System.Collections.Generic;

namespace Repozytorium.Models.Views
{
    public class OgloszeniaZKategoriiViewModels
    {
        public IList<Ogloszenie> Ogloszenia { get; set; }
        public string NazwaKategorii { get; set; }
    }
}