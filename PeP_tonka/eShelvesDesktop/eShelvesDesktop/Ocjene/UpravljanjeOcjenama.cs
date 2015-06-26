using eShelvesDesktop.Models;
using eShelvesDesktop.Ocjene;
using eShelvesDesktop.Util;
using eShelvesDesktop.ViewModels;
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

namespace eShelvesDesktop.Knjige
{
    public partial class UpravljanjeOcjenama : Form
    {
        WebApiHelper ocjeneService = new WebApiHelper(Config.urlApi, "Ocjenas");
        WebApiHelper korisniciService = new WebApiHelper(Config.urlApi, "Korisniks");
        WebApiHelper knjigeService = new WebApiHelper(Config.urlApi, "Search");

        public bool IsKnjigap { get; set; }
        public int tid { get; set; }

        public UpravljanjeOcjenama()
        {
            InitializeComponent();
            knjigeGrid.AutoGenerateColumns = false;
            ocjeneGrid.AutoGenerateColumns = false;
            korisniciGrid.AutoGenerateColumns = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e){}

        private void UpravljanjeOcjenama_Load(object sender, EventArgs e)
        {
            BindKnjige();
        }

        private void BindKnjige()
        {
            HttpResponseMessage response = knjigeService.GetResponse(knjigaInput.Text.Trim());

            if (response.IsSuccessStatusCode)
            {
                List<KnjigaVM> knjige = response.Content.ReadAsAsync<List<KnjigaVM>>().Result;
                knjigeGrid.DataSource = knjige;
            }
            else
            {
                MessageBox.Show("Error Code" +
                response.StatusCode + " : Message - " + response.ReasonPhrase);
            }
        }
        private void BindOcjene(int id, bool IsKnjiga)
        {
            IsKnjigap = IsKnjiga;
            tid = id;
            HttpResponseMessage response;
            if (IsKnjiga)
                response = ocjeneService.GetResponse(id + "");
            else
                response = ocjeneService.GetResponse("user/"+id);

            if (response.IsSuccessStatusCode)
            {
                List<OcjenaInfoVM> ocjene = response.Content.ReadAsAsync<List<OcjenaInfoVM>>().Result;
                ocjeneGrid.DataSource = ocjene;
            }
            else
            {
                MessageBox.Show("Error Code" +
                response.StatusCode + " : Message - " + response.ReasonPhrase);
            }
        }
        private void BindKorisnici()
        {
            HttpResponseMessage response = korisniciService.GetActionResponse("SearchKorisnici", korisnikInput.Text.Trim());

            if (response.IsSuccessStatusCode)
            {
                List<Korisnik> korisnici = response.Content.ReadAsAsync<List<Korisnik>>().Result;
                korisniciGrid.DataSource = korisnici;
            }
            else
            {
                MessageBox.Show("Error Code" +
                response.StatusCode + " : Message - " + response.ReasonPhrase);
            }
        }

        private void tabControl_TabIndexChanged(object sender, EventArgs e){}

        private void knjigeGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int knjigaId = (int)knjigeGrid.SelectedRows[0].Cells[0].Value;
            BindOcjene(knjigaId, true);
        }

        private void korisniciGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int korisnikId = (int)korisniciGrid.SelectedRows[0].Cells[0].Value;
            BindOcjene(korisnikId, false);
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 0)
                BindKnjige();
            else if (tabControl.SelectedIndex == 1)
                BindKorisnici();
        }

        private void korisniktraziButton_Click(object sender, EventArgs e)
        {
            BindKorisnici();
        }

        private void knjigatraziButton_Click(object sender, EventArgs e)
        {
            BindKnjige();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in ocjeneGrid.SelectedRows)
            {
                int ocjenaId = (int)row.Cells[0].Value;

                HttpResponseMessage response = ocjeneService.GetResponse("remove/" + ocjenaId);

                if (response.IsSuccessStatusCode)
                {
                    BindOcjene(tid, IsKnjigap);
                }
                else
                {
                    MessageBox.Show("Error Code" +
                    response.StatusCode + " : Message - " + response.ReasonPhrase);
                }
            }
        }

        private void ocjeneGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ocjeneGrid.SelectedRows.Count > 1)
                MessageBox.Show("da bi vidjeli detalje ocjene, mora biti označena samo jedna!");
            else
            {
                DataGridViewRow row = ocjeneGrid.SelectedRows[0];
                OcjenaInfoVM ocjena = new OcjenaInfoVM();
                ocjena.OcjenaID = (int)row.Cells[0].Value;
                ocjena.Opis = row.Cells[3].Value.ToString();
                ocjena.username = row.Cells[1].Value.ToString();
                ocjena.Ocjena = (int)row.Cells[2].Value;

                OcjenaDetalji frm = new OcjenaDetalji(ocjena);
                frm.Show();
            }
        }
    }
}
