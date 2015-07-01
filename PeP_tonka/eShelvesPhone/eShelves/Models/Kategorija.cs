using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShelves.Models
{
    public class Kategorija
    {
        public int Id { get; set; }
        public string Naziv { get; set; }

        public List<Autor> Autors { get; set; }
        public List<Knjiga> Knjigas { get; set; }
    }
}
