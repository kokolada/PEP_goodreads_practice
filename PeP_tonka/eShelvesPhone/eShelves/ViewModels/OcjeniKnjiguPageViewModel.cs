using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShelves.ViewModels
{
    public class OcjeniKnjiguPageViewModel
    {
        public int OcjenaID { get; set; }
        public int OcjenaIznos { get; set; }
        public string Opis { get; set; }

        public int KorisnikID { get; set; }

        public int KnjigaID { get; set; }
        public string Naslov { get; set; }
    }
}
