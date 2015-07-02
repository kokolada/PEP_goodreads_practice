using eShelvesDesktop.LocalModels;
using eShelvesDesktop.Models;
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

namespace eShelvesDesktop.Police
{
    public partial class ManagePolica : Form
    {
        WebApiHelper knjigaService = new WebApiHelper(Config.urlApi, "Knjigas?policaId=");
        WebApiHelper searchService = new WebApiHelper(Config.urlApi, "Search");
        WebApiHelper desktopService = new WebApiHelper(Config.urlApi, "Desktop");

        public ManagePolica(DetaljiPolice a)
        {
            InitializeComponent();
            knjigeGrid.AutoGenerateColumns = false;
            nazivLabel.Text = a.NazivPolice;
            policaidLabel.Text = a.PolicaID + "";
            usernameLabel.Text = a.usernameKorisnika;
        }

        private void ManagePolica_Load(object sender, EventArgs e)
        {
            BindGrid();

            HttpResponseMessage response = searchService.GetResponse(naslovInput.Text.Trim());

            if (response.IsSuccessStatusCode)
            {
                List<KnjigaVM> knjige = response.Content.ReadAsAsync<List<KnjigaVM>>().Result;
                pretragaGrid.DataSource = knjige;
            }
        }

        private void BindGrid()
        {
            HttpResponseMessage response = knjigaService.GetResponse2(policaidLabel.Text);

            if (response.IsSuccessStatusCode)
            {
                List<Knjiga> knjige = response.Content.ReadAsAsync<List<Knjiga>>().Result;
                knjigeGrid.DataSource = knjige;

                foreach (DataGridViewRow row in knjigeGrid.Rows)
                {
                    row.Height = 80;
                }
            }
            else
            {
                MessageBox.Show("Error Code" +
                response.StatusCode + " : Message - " + response.ReasonPhrase);
            }
        }

        private void traziButton_Click(object sender, EventArgs e)
        {
            HttpResponseMessage response = searchService.GetResponse(naslovInput.Text.Trim());

            if (response.IsSuccessStatusCode)
            {
                List<KnjigaVM> knjige = response.Content.ReadAsAsync<List<KnjigaVM>>().Result;
                pretragaGrid.DataSource = knjige;
            }
            else
            {
                MessageBox.Show("Error Code" +
                response.StatusCode + " : Message - " + response.ReasonPhrase);
            }
        }

        private void ukloniButton_Click(object sender, EventArgs e)
        {
            if (knjigeGrid.SelectedRows.Count > 0)
            {
                HttpResponseMessage response = desktopService.GetActionResponse("RemoveKnjiga", policaidLabel.Text + "/" + knjigeGrid.SelectedRows[0].Cells[0].Value.ToString());

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Knjiga uspjesno uklonjena!");
                    BindGrid();
                }
                else
                {
                    MessageBox.Show("Error Code" +
                    response.StatusCode + " : Message - " + response.ReasonPhrase);
                }
            }
        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            if (pretragaGrid.SelectedRows.Count > 0)
            {
                HttpResponseMessage response = desktopService.GetActionResponse("AddKnjigaToPolica", policaidLabel.Text + "/" + pretragaGrid.SelectedRows[0].Cells[1].Value.ToString());

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Knjiga uspjesno dodana!");
                    BindGrid();
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
