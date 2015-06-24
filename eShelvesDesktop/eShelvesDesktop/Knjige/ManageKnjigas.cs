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

namespace eShelvesDesktop
{
    public partial class ManageKnjigas : Form
    {
        WebApiHelper knjigaService = new WebApiHelper(Config.urlApi, "Search");
        WebApiHelper knjigaGetService = new WebApiHelper(Config.urlApi, "Knjigas");
        WebApiHelper ocjenaService = new WebApiHelper(Config.urlApi, "Ocjenas");

        public ManageKnjigas()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            ocjeneGrid.AutoGenerateColumns = false;
        }

        private void ManageKnjigas_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid()
        {
            HttpResponseMessage response = knjigaService.GetResponse(searchInput.Text.Trim());

            if (response.IsSuccessStatusCode)
            {
                List<KnjigaVM> knjige = response.Content.ReadAsAsync<List<KnjigaVM>>().Result;
                dataGridView1.DataSource = knjige;
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

        private void novaknjigabutton_Click(object sender, EventArgs e)
        {
            AddKnjiga frm = new AddKnjiga();
            frm.Show();
            BindGrid();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e){}

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Knjiga k = knjigaGetService.GetResponse2("?id=" + dataGridView1.SelectedRows[0].Cells[0].Value).Content.ReadAsAsync<Knjiga>().Result;
            AddKnjiga frm = new AddKnjiga(k);
            frm.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HttpResponseMessage response = ocjenaService.GetResponse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());

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
    }
}
