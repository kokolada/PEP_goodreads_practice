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
    public partial class AddKupac : Form
    {
        WebApiHelper kupacService = new WebApiHelper(Config.urlApi, "Kupac/Post");

        public AddKupac()
        {
            InitializeComponent();
        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            Kupac k = new Kupac();
            k.Naziv = nazivInput.Text;

            HttpResponseMessage response = kupacService.PostResponse(k);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show(Global.GetMessage("korisnik_succ"), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                nazivInput.Text = "";
            }
            else
                MessageBox.Show(response.ReasonPhrase, Global.GetMessage("error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
