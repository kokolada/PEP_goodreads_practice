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
			this.AutoValidate = AutoValidate.Disable;

        }

        private void AddNarudzba_Load(object sender, EventArgs e)
        {
            BindKupci();
            BindReklame();
            danaZ.Text = "0";
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
            od.Value = DateTime.Now;
            do2.Value = DateTime.Now;
            prikaziNumber.Value = 0;
            kupacCombo.SelectedIndex = 0;
            reklamaCombo.SelectedIndex = 0;
        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            DateTime d1 = od.Value;
            DateTime d2 = do2.Value;
            if (d1 < d2)
            {
                if (this.ValidateChildren())
                {
                    NarudzbeReklama narudzba = new NarudzbeReklama();

                    narudzba.BrojPrikaza = (int)prikaziNumber.Value;
                    narudzba.Cijena = (float)cijenaNumber.Value;
                    narudzba.Do = do2.Value;
                    narudzba.Od = od.Value;
                    TimeSpan span = narudzba.Do.Subtract(narudzba.Od);
                    narudzba.DanaZakupljeno = (int)span.TotalDays;

                    narudzba.KupacID = (int)kupacCombo.SelectedValue;
                    narudzba.ReklamaID = (int)reklamaCombo.SelectedValue;

                    HttpResponseMessage response = narudzbaService.PostResponse(narudzba);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show(Global.GetMessage("narudzba_succ"), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BindReklame();
                        BindKupci();
                        Clear();
                    }
                    else
                        MessageBox.Show(response.ReasonPhrase, Global.GetMessage("error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Prvi datum mora biti manji od drugog!!!!!");
            }

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

		private void prikaziNumber_Validating(object sender, CancelEventArgs e) {
			if (prikaziNumber.Value < 1) {
				e.Cancel = true;
				errorProvider.SetError(prikaziNumber, Global.GetMessage("prikazi_err"));
			}
			else
				errorProvider.SetError(prikaziNumber, "");
		}

		private void cijenaNumber_Validating(object sender, CancelEventArgs e) {
			if (cijenaNumber.Value < 0) {
				e.Cancel = true;
				errorProvider.SetError(cijenaNumber, Global.GetMessage("cijena_err"));
			}
			else
				errorProvider.SetError(cijenaNumber, "");
		}

		private void kupacCombo_Validating(object sender, CancelEventArgs e) {
			if (kupacCombo.SelectedIndex == -1) {
				e.Cancel = true;
				errorProvider.SetError(kupacCombo, Global.GetMessage("kupac_err"));
			}
			else
				errorProvider.SetError(kupacCombo, "");
		}

		private void reklamaCombo_Validating(object sender, CancelEventArgs e) {
			if (reklamaCombo.SelectedIndex == -1) {
				e.Cancel = true;
				errorProvider.SetError(reklamaCombo, Global.GetMessage("reklama_err"));
			}
			else
				errorProvider.SetError(reklamaCombo, "");
		}

        private void od_ValueChanged(object sender, EventArgs e)
        {
            DateTime d = do2.Value;
            DateTime o = od.Value;
            TimeSpan ts = d.Subtract(o);
            danaZ.Text = "" + (int)ts.TotalDays;
        }

        private void do2_ValueChanged(object sender, EventArgs e)
        {
            DateTime d = do2.Value;
            DateTime o = od.Value;
            TimeSpan ts = d.Subtract(o);
            danaZ.Text = "" + (int)ts.TotalDays;
        }
    }
}
