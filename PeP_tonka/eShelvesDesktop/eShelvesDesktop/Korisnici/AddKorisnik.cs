using eShelvesDesktop.Models;
using eShelvesDesktop.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eShelvesDesktop
{
    public partial class AddKorisnik : Form
    {
        WebApiHelper korisnikService = new WebApiHelper(Config.urlApi, "Korisniks");
        WebApiHelper policaService = new WebApiHelper(Config.urlApi, "Policas");

        private int Id;

        public AddKorisnik()
        {
            InitializeComponent();
			this.AutoValidate = AutoValidate.Disable;
        }

        public AddKorisnik(Korisnik k)
        {
            InitializeComponent();
            if(k != null)
            {
                imeInput.Text = k.Ime;
                prezimeInput.Text = k.Prezime;
                emailInput.Text = k.Email;
                usernameInput.Text = k.username;
                passwordInput.Text = k.password;
                if (k.Spol == "M")
                    muskoRB.Checked = true;
                else
                    zenskoRB.Checked = true;
                gradInput.Text = k.Grad;
                Id = k.Id;
            }
        }

        private void potvrdiButton_Click(object sender, EventArgs e)
        {
			if (this.ValidateChildren()) {
				Korisnik k = new Korisnik();
				k.Ime = imeInput.Text;
				k.Prezime = prezimeInput.Text;
				k.username = usernameInput.Text;
				k.password = passwordInput.Text;
				k.Email = emailInput.Text;
                k.created_at = DateTime.Now;
				if (muskoRB.Checked)
					k.Spol = "M";
				else if (zenskoRB.Checked)
					k.Spol = "Z";
				else
					k.Spol = "M";
				k.Grad = gradInput.Text;

				if (Id >= 1)
					k.Id = Id;

				HttpResponseMessage response = korisnikService.PostResponse(k);
				if (response.IsSuccessStatusCode) {
					MessageBox.Show(Global.GetMessage("korisnik_succ"), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
					Clear();

					if (!(Id >= 1)) {
						int korisnikId = response.Content.ReadAsAsync<Korisnik>().Result.Id;
						PolicaWM p = new PolicaWM();
						p.KorisnikID = korisnikId;
						p.BookCount = 0;

						p.Naziv = "To Read";
						policaService.PostResponse(p);

						p.Naziv = "Currently Reading";
						policaService.PostResponse(p);

						p.Naziv = "Read";
						policaService.PostResponse(p);
					}
				}
				else
					MessageBox.Show(response.ReasonPhrase, Global.GetMessage("error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
				Clear();
			}
		}

        private void Clear()
        {
            imeInput.Text = "";
            prezimeInput.Text = "";
            usernameInput.Text = "";
            passwordInput.Text = "";
            emailInput.Text = "";
            muskoRB.Checked = false;
            zenskoRB.Checked = false;
            gradInput.Text = "";
            Id = 0;
        }

        private void ponistiButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

		private void imeInput_Validating(object sender, CancelEventArgs e) {
			if (String.IsNullOrEmpty(imeInput.Text.Trim())) {
				e.Cancel = true;
				errorProvider.SetError(imeInput, Global.GetMessage("fname_req"));
			}
			else
				errorProvider.SetError(imeInput, "");
		}

		private void prezimeInput_Validating(object sender, CancelEventArgs e) {
			if (String.IsNullOrEmpty(prezimeInput.Text.Trim())) {
				e.Cancel = true;
				errorProvider.SetError(prezimeInput, Global.GetMessage("lname_req"));
			}
			else
				errorProvider.SetError(prezimeInput, "");
		}

		private void usernameInput_Validating(object sender, CancelEventArgs e) {
			if (String.IsNullOrEmpty(usernameInput.Text.Trim())) {
				e.Cancel = true;
				errorProvider.SetError(usernameInput, Global.GetMessage("usern_req"));
			}
			else if (usernameInput.TextLength < 5) {
				e.Cancel = true;
				errorProvider.SetError(usernameInput, Global.GetMessage("usern_err"));
			}
			else
				errorProvider.SetError(usernameInput, "");
		}

		private void passwordInput_Validating(object sender, CancelEventArgs e) {
            if (Id == 0)
            {
                if (String.IsNullOrEmpty(passwordInput.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider.SetError(passwordInput, Global.GetMessage("pass_req"));
                }
                else if (passwordInput.TextLength < 8)
                {
                    e.Cancel = true;
                    errorProvider.SetError(passwordInput, Global.GetMessage("pass_err"));
                }
                else
                    errorProvider.SetError(passwordInput, "");
            }
		}

		private void emailInput_Validating(object sender, CancelEventArgs e) {
			if (String.IsNullOrEmpty(emailInput.Text.Trim())) {
				e.Cancel = true;
				errorProvider.SetError(emailInput, Global.GetMessage("email_req"));
			}
			else {
				try {
					MailAddress mail = new MailAddress(emailInput.Text);
					errorProvider.SetError(emailInput, "");

				}
				catch (FormatException) {
					e.Cancel = true;
					errorProvider.SetError(emailInput, Global.GetMessage("email_err"));
				}
			}
		}

		private void gradInput_Validating(object sender, CancelEventArgs e) {
			if (String.IsNullOrEmpty(gradInput.Text.Trim())) {
				e.Cancel = true;
				errorProvider.SetError(gradInput, Global.GetMessage("grad_req"));
			}
			else
				errorProvider.SetError(gradInput, "");
		}

		private void zenskoRB_Validating(object sender, CancelEventArgs e) {
			if (!(muskoRB.Checked) && !(zenskoRB.Checked)) {
				e.Cancel = true;
				errorProvider.SetError(zenskoRB, Global.GetMessage("spol_req"));
			}
			else
				errorProvider.SetError(zenskoRB, "");
		}

        private void AddKorisnik_Load(object sender, EventArgs e)
        {
            if (Id > 0)
            {
                usernameInput.ReadOnly = true;
                passwordInput.ReadOnly = true;
            }
        }
    }
}
