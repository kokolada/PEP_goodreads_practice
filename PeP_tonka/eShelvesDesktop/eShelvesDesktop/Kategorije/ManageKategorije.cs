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

namespace eShelvesDesktop.Kategorije
{
    public partial class ManageKategorije : Form
    {
        WebApiHelper kategorijaService = new WebApiHelper(Config.urlApi, "Desktop");

        private List<Kategorija> kategorije { get; set; }

        public ManageKategorije()
        {
            InitializeComponent();
        }

        private void ManageKategorije_Load(object sender, EventArgs e)
        {
            BindKategorijas();
        }

        private void BindKategorijas()
        {
            kategorije = kategorijaService.GetResponse("Kategorijas").Content.ReadAsAsync<List<Kategorija>>().Result;
            kategorijeListBox.Items.Clear();
            kategorijeListBox.Items.AddRange(kategorije.Select(x => x.Naziv).ToArray());
        }

        private void obrisiButton_Click(object sender, EventArgs e)
        {
            foreach(int indeks in kategorijeListBox.CheckedIndices)
            {
                HttpResponseMessage response = kategorijaService.GetResponse("Kategorijas/Remove/" + kategorije[indeks].Id);
                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Error Code" +
                    response.StatusCode + " : Message - " + response.ReasonPhrase);
                }
            }
            BindKategorijas();
        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            if (novaInput.Text.Count() > 1)
            {
                Kategorija k = new Kategorija();
                k.Naziv = novaInput.Text;

                HttpResponseMessage response = kategorijaService.PostResponse(k);

                if (response.IsSuccessStatusCode)
                {
                    BindKategorijas();
                }
                else
                {
                    MessageBox.Show("Error Code" +
                    response.StatusCode + " : Message - " + response.ReasonPhrase);
                }
            }
        }
    }
}
