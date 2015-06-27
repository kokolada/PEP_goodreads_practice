using eShelves.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace eShelves
{
    public class Global
    {
        public static LogiraniKorisnik prijavljeniKorisnik { get; set; }

        public static string GetMessage(string key)
        {
            ResourceManager rm = new ResourceManager("eShelvesDesktop.Messages", typeof(Global).GetTypeInfo().Assembly);
            return rm.GetString(key);
        }
    }
}
