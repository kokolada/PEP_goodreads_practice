using eShelvesDesktop.Models;
using eShelvesDesktop.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eShelvesDesktop
{
    public partial class AddKorisnik : Form
    {
        WebApiHelper korisnikService = new WebApiHelper(Config.urlApi, "Korisniks");
        public AddKorisnik()
        {
            InitializeComponent();
        }

        private void potvrdiButton_Click(object sender, EventArgs e)
        {
            Korisnik k = new Korisnik();
            k.Ime = imeInput.Text;
            k.Prezime = prezimeInput.Text;
            k.username = usernameInput.Text;
            k.password = passwordInput.Text;
            k.Email = emailInput.Text;
            if (muskoRB.Checked)
                k.Spol = "M";
            else if (zenskoRB.Checked)
                k.Spol = "Z";
            else
                k.Spol = "M";
            k.Grad = gradInput.Text;

            HttpResponseMessage response = korisnikService.PostResponse(k);
            //if(response.IsSuccessStatusCode)
        }
    }
}
