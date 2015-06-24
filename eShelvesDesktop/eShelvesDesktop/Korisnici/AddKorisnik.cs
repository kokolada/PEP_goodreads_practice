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
        WebApiHelper policaService = new WebApiHelper(Config.urlApi, "Policas");

        private int Id;

        public AddKorisnik()
        {
            InitializeComponent();
        }

        public AddKorisnik(Korisnik k)
        {
            InitializeComponent();
            if(k != null)
            {
                imeInput.Text = k.Ime;
                prezimeInput.Text = k.Prezime;
                emailInput.Text = k.Email;
                usernameInput.Text = k.username;
                if (k.Spol == "M")
                    muskoRB.Checked = true;
                else
                    zenskoRB.Checked = true;
                gradInput.Text = k.Grad;
                Id = k.Id;
            }
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

            if (Id >= 1)
                k.Id = Id;

            HttpResponseMessage response = korisnikService.PostResponse(k);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show(Global.GetMessage("korisnik_succ"), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();

                if (!(Id >= 1))
                {
                    int korisnikId = response.Content.ReadAsAsync<Korisnik>().Result.Id;
                    PolicaWM p = new PolicaWM();
                    p.KorisnikID = korisnikId;
                    p.BookCount = 0;

                    p.Naziv = "To Read";
                    policaService.PostResponse(p);

                    p.Naziv = "Currently Reading";
                    policaService.PostResponse(p);

                    p.Naziv = "Read";
                    policaService.PostResponse(p);
                }
            }
            else
                MessageBox.Show(response.ReasonPhrase, Global.GetMessage("error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            Clear();
        }

        private void Clear()
        {
            imeInput.Text = "";
            prezimeInput.Text = "";
            usernameInput.Text = "";
            passwordInput.Text = "";
            emailInput.Text = "";
            muskoRB.Checked = false;
            zenskoRB.Checked = false;
            gradInput.Text = "";
            Id = 0;
        }

        private void ponistiButton_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
