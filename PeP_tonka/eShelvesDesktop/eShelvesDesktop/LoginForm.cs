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
    public partial class LoginForm : Form
    {
        WebApiHelper serviceCaller = new WebApiHelper(Config.urlApi, "Administrators");
        public LoginForm()
        {
            InitializeComponent();
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void potvrdiButton_Click(object sender, EventArgs e)
        {
            HttpResponseMessage response = serviceCaller.GetResponse("Login/"+usernameInput.Text);

            if (response.IsSuccessStatusCode)
            {
                Administrator korisnik = response.Content.ReadAsAsync<Administrator>().Result;
                if (korisnik != null && korisnik.PasswordHash == KorisniciHelper.GenerateHash(passwordInput.Text, korisnik.PasswordSalt))
                {
                    LogiraniKorisnik k = new LogiraniKorisnik();
                    k.Id = korisnik.Id;
                    k.password = korisnik.PasswordHash;
                    k.username = korisnik.username;
                    Global.prijavljeniKorisnik = k;
                    this.DialogResult = DialogResult.OK;
                }
                else
                    MessageBox.Show(Global.GetMessage("login_pass_err"), Global.GetMessage("error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show(Global.GetMessage("login_err"), Global.GetMessage("error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void passwordInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                potvrdiButton_Click(sender, EventArgs.Empty);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            usernameInput.Text = "dzemo";
            passwordInput.Text = "gigant";
        }
    }
}
