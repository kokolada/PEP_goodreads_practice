using eShelves.Util;
using eShelves.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage.Pickers.Provider;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Content Dialog item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace eShelves.Dialogs
{
    public sealed partial class NovaPolicaDialog : ContentDialog
    {
        WebApiHelper policaService = new WebApiHelper(Config.urlApi, "Policas");

        public NovaPolicaDialog()
        {
            this.InitializeComponent();
        }

        private void ContentDialog_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
        }

        private void ContentDialog_SecondaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (naziv.Text.Length > 0)
            {
                PolicaWM polica = new PolicaWM();
                polica.Naziv = naziv.Text;
                polica.KorisnikID = Global.prijavljeniKorisnik.Id;
                HttpResponseMessage response = policaService.PostResponse(polica);

                if (response.IsSuccessStatusCode)
                {
                    MessageDialog msg = new MessageDialog("Polica uspješno dodana!");
                    msg.ShowAsync();
                }
                else
                {
                    body.Text = "Greška!";
                }
                this.Hide();
            }
            else
            {
                body.Text = "UNESITE NAZIV POLICE";
            }
        }
    }
}
