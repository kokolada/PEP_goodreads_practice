using eShelvesDesktop.Models;
using eShelvesDesktop.Util;
using eShelvesDesktop.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eShelvesDesktop
{
    public partial class AddKnjiga : Form
    {
        WebApiHelper autorService = new WebApiHelper(Config.urlApi, "Autor");
        WebApiHelper addKnjigaService = new WebApiHelper(Config.urlApi, "NeznamStaRadim");
        WebApiHelper kategorijaService = new WebApiHelper(Config.urlApi, "Desktop");

        private List<Kategorija> kategorije { get; set; }
        private List<Kategorija> k2 { get; set; }
        private Knjiga knjiga { get; set; }
        private int Id;
        private int AutorID;

        public AddKnjiga()
        {
            InitializeComponent();
			this.AutoValidate = AutoValidate.Disable;
        }

        public AddKnjiga(Knjiga k)
        {
            InitializeComponent();
            naslovInput.Text = k.Naslov;
            opisInput.Text = k.Opis;
            ISBNInput.Text = k.ISBN;
            objavljenaDatePicker.Value = k.Objavljena;
            Id = k.Id;
            AutorID = k.AutorId;

            if (Id >= 1)
                k2 = new List<Kategorija>(k.Kategorijas);

            if (k.Slika != null)
            {
                MemoryStream ms = new MemoryStream(k.Slika);
                pictureBox.Image = Image.FromStream(ms);
            }
        }

        private void AddKnjiga_Load(object sender, EventArgs e)
        {
            BindAutors();
            BindKategorijas();
            if (Id >= 1)
                CheckTheBoxes(k2);
        }

        private void CheckTheBoxes(List<Kategorija> kategorijj)
        {
            for(int j = 0; j<kategorijeListBox.Items.Count; j++)
            {
                for(int i = 0; i<kategorijj.Count; i++)
                {
                    if ((string)kategorijeListBox.Items[j] == kategorijj[i].Naziv)
                        kategorijeListBox.SetItemCheckState(j, CheckState.Checked);
                }
            }
        }

        private void BindKategorijas()
        {
            kategorije = kategorijaService.GetResponse("Kategorijas").Content.ReadAsAsync<List<Kategorija>>().Result;
            kategorijeListBox.Items.Clear();
            kategorijeListBox.Items.AddRange(kategorije.Select(x => x.Naziv).ToArray());
        }

        private void BindAutors()
        {
            HttpResponseMessage response = autorService.GetResponse();

            if (response.IsSuccessStatusCode)
            {
                List<AutorVM> autori = response.Content.ReadAsAsync<List<AutorVM>>().Result;
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
                }
            }
        }

        private void sacuvajButton_Click(object sender, EventArgs e)
        {
			if (this.ValidateChildren()) {
				if (knjiga == null)
					knjiga = new Knjiga();

				if (autorComboBox.SelectedIndex != 0)
					knjiga.AutorId = Convert.ToInt32(autorComboBox.SelectedValue);

				knjiga.Naslov = naslovInput.Text;
				knjiga.ISBN = ISBNInput.Text;
				knjiga.Opis = opisInput.Text;
				knjiga.Objavljena = objavljenaDatePicker.Value;

				knjiga.Kategorijas = new List<Kategorija>();
				foreach (int indeks in kategorijeListBox.CheckedIndices) {
					knjiga.Kategorijas.Add(kategorije[indeks]);
				}

				if (Id >= 1)
					knjiga.Id = Id;

				HttpResponseMessage response = addKnjigaService.PostResponse(knjiga);

				if (response.IsSuccessStatusCode) {
					MessageBox.Show(Global.GetMessage("knjigaAdd_succ"), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
					Clear();
				}
				else {
					MessageBox.Show(response.ReasonPhrase, Global.GetMessage("error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				Clear();
			}
        }

        private void Clear()
        {
            knjiga = null;
            naslovInput.Text = "";
            ISBNInput.Text = "";
            autorComboBox.SelectedIndex = 0;
            slikaInput.Text = "";
            pictureBox.Image = null;
            opisInput.Text = "";
        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (knjiga == null)
                    knjiga = new Knjiga();

                openFileDialog.ShowDialog();
                slikaInput.Text = openFileDialog.FileName;

                Image image = Image.FromFile(slikaInput.Text);

                MemoryStream ms = new MemoryStream();
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                knjiga.Slika = ms.ToArray();
                pictureBox.Image = image;
            }
            catch (Exception)
            {
                knjiga = null;
                pictureBox.Image = null;
                slikaInput.Text = "";
            }
        }
		#region Validacija
		private void naslovInput_Validating(object sender, CancelEventArgs e) {
			if (String.IsNullOrEmpty(naslovInput.Text)) {
				e.Cancel = true;
				errorProvider.SetError(naslovInput, Global.GetMessage("naslov_req"));
			}
			else
				errorProvider.SetError(naslovInput, "");
		}

		private void ISBNInput_Validating(object sender, CancelEventArgs e) {
			if (String.IsNullOrEmpty(ISBNInput.Text)) {
				e.Cancel = true;
				errorProvider.SetError(ISBNInput, Global.GetMessage("isbn_req"));
			}
            else if (!Regex.IsMatch(ISBNInput.Text, "^[0-9]*$"))
                errorProvider.SetError(ISBNInput, Global.GetMessage("isbn_numb"));
            else
                errorProvider.SetError(ISBNInput, "");
		}

		private void autorComboBox_Validating(object sender, CancelEventArgs e) {
			if (autorComboBox.SelectedIndex == 0) 
			{
				e.Cancel = true;
				errorProvider.SetError(autorComboBox, Global.GetMessage("autor_req"));
			}
			else
				errorProvider.SetError(autorComboBox, "");
		}

		private void opisInput_Validating(object sender, CancelEventArgs e) {
			if (String.IsNullOrEmpty(opisInput.Text)) {
				e.Cancel = true;
				errorProvider.SetError(opisInput, Global.GetMessage("opis_req"));
			}
            else
                errorProvider.SetError(opisInput, "");
		}

		private void kategorijeListBox_Validating(object sender, CancelEventArgs e) {
			if (kategorijeListBox.CheckedItems.Count == 0) {
				e.Cancel = true;
				errorProvider.SetError(kategorijeListBox, Global.GetMessage("kategorije_req"));
			}
			else
				errorProvider.SetError(kategorijeListBox, "");
		}
		#endregion
    }
}
