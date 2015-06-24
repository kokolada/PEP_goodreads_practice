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
    public partial class ManageKorisniks : Form
    {
        WebApiHelper korisniciService = new WebApiHelper(Config.urlApi, "Korisniks");

        public ManageKorisniks()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
        }

        private void ManageKorisniks_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid()
        {
            HttpResponseMessage response = korisniciService.GetActionResponse("SearchKorisnici", usernameInput.Text.Trim());

            if (response.IsSuccessStatusCode)
            {
                List<Korisnik> korisnici = response.Content.ReadAsAsync<List<Korisnik>>().Result;
                dataGridView1.DataSource = korisnici;
            }
            else
            {
                MessageBox.Show("Error Code" +
                response.StatusCode + " : Message - " + response.ReasonPhrase);
            }
        }

        private void traziButton_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            AddKorisnik frm = new AddKorisnik();
            frm.Show();
            BindGrid();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Korisnik k = korisniciService.GetResponse2("?id=" + dataGridView1.SelectedRows[0].Cells[0].Value).Content.ReadAsAsync<Korisnik>().Result;
            AddKorisnik frm = new AddKorisnik(k);
            frm.Show();
        }
    }
}
