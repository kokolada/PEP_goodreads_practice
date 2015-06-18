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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eShelvesDesktop
{
    public partial class AddKnjiga : Form
    {
        WebApiHelper autorService = new WebApiHelper(Config.urlApi, "Autor");
        WebApiHelper addKnjigaService = new WebApiHelper(Config.urlApi, "NeznamStaRadim");

        private Knjiga knjiga { get; set; }

        public AddKnjiga()
        {
            InitializeComponent();
        }

        private void AddKnjiga_Load(object sender, EventArgs e)
        {
            BindAutors();
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
            }
        }

        private void sacuvajButton_Click(object sender, EventArgs e)
        {
            if (knjiga == null)
                knjiga = new Knjiga();

            if (autorComboBox.SelectedIndex != 0)
                knjiga.AutorId = Convert.ToInt32(autorComboBox.SelectedValue);

            knjiga.Naslov = naslovInput.Text;
            knjiga.ISBN = ISBNInput.Text;
            knjiga.Opis = opisInput.Text;
            knjiga.Objavljena = objavljenaDatePicker.Value;

            HttpResponseMessage response = addKnjigaService.PostResponse(knjiga);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show(Global.GetMessage("product_succ"), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
            }
            else
            {
                MessageBox.Show(response.ReasonPhrase, Global.GetMessage("error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Clear();
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
    }
}
