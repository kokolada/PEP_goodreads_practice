﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShelves.ViewModels
{
    public class KnjigaVM
    {
        public int Id { get; set; }
        public string Naslov { get; set; }
        public string ISBN { get; set; }
        public int AutorId { get; set; }
        public string NazivAutora { get; set; }
        public byte[] Slika { get; set; }
    }
}
