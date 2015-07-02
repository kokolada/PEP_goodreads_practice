using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShelves.ViewModels
{
    public class PolicaDetaljiViewModel
    {
        public int PolicaID { get; set; }
        public string Naziv { get; set; }

        public List<KnjigaInfo> Knjige { get; set; }

        public class KnjigaInfo
        {
            public int KnjigaID { get; set; }
            public string Naslov { get; set; }
            public string Autor { get; set; }
            public float ProsjecnaOcjena { get; set; }
            public byte[] Slika { get; set; }
        }
    }
}
