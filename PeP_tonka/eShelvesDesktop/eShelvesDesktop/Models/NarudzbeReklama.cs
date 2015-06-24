using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShelvesDesktop.Models
{
    public class NarudzbeReklama
    {
        public int Id { get; set; }
        public int DanaZakupljeno { get; set; }
        public float Cijena { get; set; }
        public int BrojPrikaza { get; set; }

        public int ReklamaID { get; set; }
        public int KupacID { get; set; }
    }
}
