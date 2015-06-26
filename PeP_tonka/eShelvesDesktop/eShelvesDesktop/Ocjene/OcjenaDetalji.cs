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

namespace eShelvesDesktop.Ocjene
{
    public partial class OcjenaDetalji : Form
    {
        WebApiHelper ocjenaRemoveService = new WebApiHelper(Config.urlApi, "Ocjenas/remove");

        public int OcjenaID { get; set; }

        public OcjenaDetalji(OcjenaInfoVM o)
        {
            InitializeComponent();
            OcjenaID = o.OcjenaID;
            ocjenaLabel.Text = o.Ocjena + "";
            userLabel.Text = o.username;
            opisInput.Text = o.Opis;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HttpResponseMessage response = ocjenaRemoveService.GetResponse(OcjenaID+"");

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Ocjena uspješno obrisana!");
                Close();
            }
            else
            {
                MessageBox.Show("Error Code" +
                response.StatusCode + " : Message - " + response.ReasonPhrase);
            }
        }
    }
}
