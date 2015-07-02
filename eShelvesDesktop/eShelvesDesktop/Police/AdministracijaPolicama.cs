using eShelvesDesktop.LocalModels;
using eShelvesDesktop.Models;
using eShelvesDesktop.Police;
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
    public partial class AdministracijaPolicama : Form
    {
        WebApiHelper korisniciService = new WebApiHelper(Config.urlApi, "Korisniks");
        WebApiHelper policaService = new WebApiHelper(Config.urlApi, "Policas?korisnikId=");

        public AdministracijaPolicama()
        {
            InitializeComponent();
            korisniciGrid.AutoGenerateColumns = false;
            policeGrid.AutoGenerateColumns = false;
        }

        private void AdministracijaPolicama_Load(object sender, EventArgs e)
        {
            BindKorisniciGrid();
        }

        private void BindKorisniciGrid()
        {
            HttpResponseMessage response = korisniciService.GetActionResponse("SearchKorisnici", usernameInput.Text.Trim());

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

        private void korisniciGrid_CellContentClick(object sender, DataGridViewCellEventArgs e){}

        private void BindPolicaGrid(int value)
        {
            HttpResponseMessage response = policaService.GetResponse2(value + "");

            if (response.IsSuccessStatusCode)
            {
                List<PolicaWM> Police = response.Content.ReadAsAsync<List<PolicaWM>>().Result;
                policeGrid.DataSource = Police;
            }
            else
            {
                MessageBox.Show("Error Code" +
                response.StatusCode + " : Message - " + response.ReasonPhrase);
            }
        }

        private void policeGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e){}

        private void policeGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DetaljiPolice dp = new DetaljiPolice();
            dp.PolicaID = (int)policeGrid.SelectedRows[0].Cells[0].Value;
            dp.NazivPolice = policeGrid.SelectedRows[0].Cells[1].Value.ToString();
            dp.usernameKorisnika = korisniciGrid.SelectedRows[0].Cells[1].Value.ToString();

            ManagePolica frm = new ManagePolica(dp);
            frm.Show();
        }

        private void korisniciGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e){}

        private void korisniciGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BindPolicaGrid((int)korisniciGrid.SelectedRows[0].Cells[0].Value);
        }

        private void traziButton_Click(object sender, EventArgs e)
        {
            HttpResponseMessage response = korisniciService.GetActionResponse("SearchKorisnici", usernameInput.Text.Trim());

            if (response.IsSuccessStatusCode)
            {
                List<Korisnik> korisnici = response.Content.ReadAsAsync<List<Korisnik>>().Result;
                korisniciGrid.DataSource = korisnici;
            }
        }
    }
}
