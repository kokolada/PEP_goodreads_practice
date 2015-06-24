﻿using eShelvesDesktop.Models;
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
    public partial class AddReklama : Form
    {
        WebApiHelper reklamaService = new WebApiHelper(Config.urlApi, "Reklama/Post");

        public AddReklama()
        {
            InitializeComponent();
        }

        private void ponistiButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            pocetakDate.Value = DateTime.Now;
            trajanjeNumber.Value = 0;
            urlInput.Text = "";
        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            Reklama r = new Reklama();
            r.PocetakPrikazivanja = pocetakDate.Value;
            r.TrajanjeDana = (int)trajanjeNumber.Value;
            r.URL = urlInput.Text;

            HttpResponseMessage response = reklamaService.PostResponse(r);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show(Global.GetMessage("korisnik_succ"), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
            }
            else
                MessageBox.Show(response.ReasonPhrase, Global.GetMessage("error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
