using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShelves.Models
{
    public class Reklama
    {
        public int Id { get; set; }
        public DateTime PocetakPrikazivanja { get; set; }
        public int TrajanjeDana { get; set; }
        public string URL { get; set; }
    }
}
