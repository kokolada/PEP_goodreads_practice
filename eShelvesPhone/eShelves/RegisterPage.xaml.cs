using eShelves.Models;
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
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace eShelves
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class RegisterPage : Page
    {
        WebApiHelper korisnikService = new WebApiHelper(Config.urlApi, "Korisniks");
        WebApiHelper policaService = new WebApiHelper(Config.urlApi, "Policas");
        WebApiHelper usernameService = new WebApiHelper(Config.urlApi, "Username");

        public RegisterPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            HttpResponseMessage uq = usernameService.GetResponse(usernameInput.Text.Trim());
            if (uq.Content.ReadAsAsync<bool>().Result == true)
            {
                Korisnik k = new Korisnik();
                k.created_at = DateTime.Now;
                k.Email = emailInput.Text;
                k.Grad = gradInput.Text;
                k.Ime = imeInput.Text;
                k.password = passwordInput.Password;
                k.Prezime = prezimeInput.Text;
                if (muskoRB.IsChecked == true)
                    k.Spol = "M";
                else if (zenskoRB.IsChecked == true)
                    k.Spol = "Z";
                else
                    k.Spol = "M";
                k.username = usernameInput.Text;

                HttpResponseMessage response = korisnikService.PostResponse(k);

                if (response.IsSuccessStatusCode)
                {
                    PolicaWM p = new PolicaWM();
                    p.KorisnikID = response.Content.ReadAsAsync<Korisnik>().Result.Id;
                    p.BookCount = 0;

                    p.Naziv = "To Read";
                    policaService.PostResponse(p);

                    p.Naziv = "Currently Reading";
                    policaService.PostResponse(p);

                    p.Naziv = "Read";
                    policaService.PostResponse(p);

                    MessageDialog msg = new MessageDialog("Registracija uspješna!");
                    await msg.ShowAsync();
                    Frame.Navigate(typeof(LoginPage));
                }
                else
                {
                    MessageDialog msg = new MessageDialog("Registracija nije uspješna!");
                    await msg.ShowAsync();
                    Frame.Navigate(typeof(LoginPage));
                }
            }
            else
            {
                MessageDialog msg = new MessageDialog("Username već postoji!");
                await msg.ShowAsync();
            }
        }
    }
}
