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
    public partial class AddNarudzba : Form
    {
        WebApiHelper kupciService = new WebApiHelper(Config.urlApi, "Kupac");
        WebApiHelper reklameService = new WebApiHelper(Config.urlApi, "Reklama");
        WebApiHelper narudzbaService = new WebApiHelper(Config.urlApi, "Narudzba/Post");

        public AddNarudzba()
        {
            InitializeComponent();
        }

        private void AddNarudzba_Load(object sender, EventArgs e)
        {
            BindKupci();
            BindReklame();
        }

        private void BindKupci()
        {
            HttpResponseMessage response = kupciService.GetResponse();

            kupacCombo.DataSource = response.Content.ReadAsAsync<List<Kupac>>().Result;
            kupacCombo.DisplayMember = "Naziv";
            kupacCombo.ValueMember = "Id";
        }

        private void BindReklame()
        {
            HttpResponseMessage response = reklameService.GetResponse();

            reklamaCombo.DataSource = response.Content.ReadAsAsync<List<Reklama>>().Result;
            reklamaCombo.DisplayMember = "URL";
            reklamaCombo.ValueMember = "Id";
        }

        private void ponistiButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            cijenaNumber.Value = 0;
            danaNumber.Value = 0;
            prikaziNumber.Value = 0;
            kupacCombo.SelectedIndex = 0;
            reklamaCombo.SelectedIndex = 0;
        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            NarudzbeReklama narudzba = new NarudzbeReklama();

            narudzba.BrojPrikaza = (int)prikaziNumber.Value;
            narudzba.Cijena = (float)cijenaNumber.Value;
            narudzba.DanaZakupljeno = (int)danaNumber.Value;

            narudzba.KupacID = (int)kupacCombo.SelectedValue;
            narudzba.ReklamaID = (int)reklamaCombo.SelectedValue;

            HttpResponseMessage response = narudzbaService.PostResponse(narudzba);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show(Global.GetMessage("korisnik_succ"), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BindReklame();
                BindKupci();
                Clear();
            }
            else
                MessageBox.Show(response.ReasonPhrase, Global.GetMessage("error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void addkupacButton_Click(object sender, EventArgs e)
        {
            AddKupac frm = new AddKupac();
            frm.Show();
        }

        private void addreklamaButton_Click(object sender, EventArgs e)
        {
            AddReklama frm = new AddReklama();
            frm.Show();
        }
    }
}
