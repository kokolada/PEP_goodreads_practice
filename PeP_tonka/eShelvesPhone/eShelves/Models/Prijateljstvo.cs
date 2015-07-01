using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShelves.Models
{
    public class Prijateljstvo
    {
        public int Korisnik1ID { get; set; }
        public int Korisnik2ID { get; set; }
        public int Status { get; set; }
        public int UputioZahtjevID { get; set; }

        public Korisnik Korisnik1 { get; set; }
        public Korisnik Korisnik2 { get; set; }
        //vidjet kako za Status koristik helper enumeraciju da ne stoji ruzni brojevi
        //(tipa StatusType.Blocked, StatusType.Pending i tako)
    }
}
