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

namespace eShelvesDesktop.Autori
{
    public partial class EvidencijaAutora : Form
    {
        WebApiHelper kategorijaService = new WebApiHelper(Config.urlApi, "Desktop");
        WebApiHelper autorService = new WebApiHelper(Config.urlApi, "Autor");

        private List<Kategorija> kategorije { get; set; }
        public int Id { get; set; }

        public EvidencijaAutora()
        {
            InitializeComponent();
            autoriGrid.AutoGenerateColumns = false;
        }

        private void EvidencijaAutora_Load(object sender, EventArgs e)
        {
            BindKategorijas();
            BindAutors();
        }

        private void BindAutors()
        {
            HttpResponseMessage response = autorService.GetResponse("Search/"+searchInput.Text.Trim());

            if (response.IsSuccessStatusCode)
            {
                /*List<AutorVM> autori = response.Content.ReadAsAsync<List<AutorVM>>().Result;
                autori.Insert(0, new AutorVM());
                autorComboBox.DataSource = autori;
                autorComboBox.DisplayMember = "Naziv";
                autorComboBox.ValueMember = "Id";

                if (Id >= 1)
                {
                    for (int i = 0; i < autori.Count; i++)
                    {
                        if (autori[i].Id == AutorID)
                            autorComboBox.SelectedIndex = i;
                    }
                }*/
                List<Autor> autori = response.Content.ReadAsAsync<List<Autor>>().Result;
                autoriGrid.DataSource = autori;
            }
            else
            {
                MessageBox.Show("Error Code" +
                response.StatusCode + " : Message - " + response.ReasonPhrase);
            }
        }

        private void BindKategorijas()
        {
            kategorije = kategorijaService.GetResponse("Kategorijas").Content.ReadAsAsync<List<Kategorija>>().Result;
            kategorijeListBox.Items.Clear();
            kategorijeListBox.Items.AddRange(kategorije.Select(x => x.Naziv).ToArray());
        }

        private void ponistiButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            BindKategorijas();
            BindAutors();
            imeInput.Text = "";
            prezimeInput.Text = "";
            gradInput.Text = "";
            rodjenPicker.Value = DateTime.Now;
            opisInput.Text = "";
            webInput.Text = "";
            searchInput.Text = "";
        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            Autor a = new Autor();
            a.Ime = imeInput.Text;
            a.Prezime = prezimeInput.Text;
            a.MjestoRodjenja = gradInput.Text;
            a.Opis = opisInput.Text;
            a.Rodjen = rodjenPicker.Value;
            a.WebStranica = webInput.Text;

            /*a.Kategorijas = new List<Kategorija>();

            foreach(int i in kategorijeListBox.CheckedIndices)
            {
                a.Kategorijas.Add(kategorije[i]);
            }*/

            HttpResponseMessage response = autorService.PostResponse(a);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Autor uspjesno dodan!");
                Clear();
            }
            else
            {
                MessageBox.Show("Error Code" +
                response.StatusCode + " : Message - " + response.ReasonPhrase);
            }
        }

        private void autoriGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //popuniti gornje kontrole
            HttpResponseMessage response = autorService.GetResponse2("?id=" + autoriGrid.SelectedRows[0].Cells[0].Value.ToString());

            if (response.IsSuccessStatusCode)
            {
                Autor a = response.Content.ReadAsAsync<Autor>().Result;

                imeInput.Text = a.Ime;
                prezimeInput.Text = a.Prezime;
                gradInput.Text = a.MjestoRodjenja;
                rodjenPicker.Value = a.Rodjen;
                webInput.Text = a.WebStranica;
                opisInput.Text = a.Opis;
                Id = a.Id;

                if(a.Kategorijas != null)
                    CheckTheBoxes(a.Kategorijas);
            }
        }

        private void CheckTheBoxes(List<Kategorija> kategorijj)
        {
            for (int j = 0; j < kategorijeListBox.Items.Count; j++)
            {
                for (int i = 0; i < kategorijj.Count; i++)
                {
                    if ((string)kategorijeListBox.Items[j] == kategorijj[i].Naziv)
                        kategorijeListBox.SetItemCheckState(j, CheckState.Checked);
                }
            }
        }

        private void autoriGrid_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu m = new ContextMenu();
                m.MenuItems.Add(new MenuItem("Remove"));

                var r = autoriGrid.HitTest(e.X, e.Y);
                if (r.RowIndex >= 0)
                {
                    autoriGrid.ClearSelection();
                    autoriGrid.Rows[r.RowIndex].Selected = true;

                    m.Show(autoriGrid, new Point(e.X, e.Y));

                    m.MenuItems[0].Click += new EventHandler(ObrisiKnjigu);
                }
            }
        }

        private void ObrisiKnjigu(object sender, EventArgs e)
        {
            HttpResponseMessage response = autorService.GetResponse("Remove/" + autoriGrid.SelectedRows[0].Cells[0].Value.ToString());

            if (response.IsSuccessStatusCode)
            {
                BindAutors();
            }
            else
            {
                MessageBox.Show("Error Code" +
                response.StatusCode + " : Message - " + response.ReasonPhrase);
            }
        }
    }
}
